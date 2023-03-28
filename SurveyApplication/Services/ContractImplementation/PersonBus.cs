using Microsoft.EntityFrameworkCore;
using SurveyApplication.Data;
using SurveyApplication.Models;
using SurveyApplication.Services.Contract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.Services.ContractImplementation
{
    public class PersonBus : IPersonBus
    {
        private readonly ApplicationDbContext _context;

        public PersonBus(ApplicationDbContext context)
        {
            _context = context;
        }
        public async Task<Person> addPerson(Person person)
        {
            Person addPerson = _context.Persons.Add(person).Entity;
            await _context.SaveChangesAsync();
            return addPerson;
        }

        public async Task addPersonAnswer(PersonAnswer personAnswer)
        {
            _context.PersonAnswers.Add(personAnswer);
            await _context.SaveChangesAsync();
        }

        public async Task<List<Answer>> getAllAnswers()
        {
            List<Answer> answers = await _context.Answers.ToListAsync();
            return answers;
        }

    }
}
