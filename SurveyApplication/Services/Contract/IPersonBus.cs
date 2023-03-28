using SurveyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.Services.Contract
{
    public interface IPersonBus
    {
        Task<Person> addPerson(Person person);
        Task addPersonAnswer(PersonAnswer personAnswer);

        Task<List<Answer>> getAllAnswers();
    }
}
