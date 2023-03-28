using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Newtonsoft.Json;
using SurveyApplication.Models;
using SurveyApplication.Services.Contract;
using SurveyApplication.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.Controllers
{
    public class PersonsController : Controller
    {

        private readonly IPersonBus _personBus;
        public PersonsController(IPersonBus personBus)
        {
            _personBus = personBus;
        }

        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }

        [HttpGet]
        public async Task<IActionResult> AddSurvey()
        {
            SurveyViewModel model = new SurveyViewModel();
            List<Answer> answers = await _personBus.getAllAnswers();
            ViewData["answers"] = new SelectList(answers, "AnswerId", "AnswerValue");
            return View(model);
        }

        [HttpGet]

        public IActionResult DisplayMembersFields(int num,string members)
        {
            var data = JsonConvert.DeserializeObject<List<Person>>(members);
            var model = new MembersViewModel
            {
                num = num,
                members = data
            };

            return PartialView("_members", model);
        }

        [HttpPost]
        public async Task<IActionResult> AddSurvey(SurveyViewModel model)
        {
            Person personHousHold = await _personBus.addPerson(model.HouseHold);
            foreach (Person member in model.Members)
            {
                member.ParentId = personHousHold.PersonId;
                await _personBus.addPerson(member);
            }
            foreach (int ans in model.Answers)
            {
                PersonAnswer personAnswer = new PersonAnswer
                {
                    PersonId = personHousHold.PersonId,
                    AnswerId = ans,
                    Desc = ans == 4 ? model.Desc:null
                };
                await _personBus.addPersonAnswer(personAnswer);
            }
            return RedirectToAction(nameof(AddSurvey));
        }
    }
}
