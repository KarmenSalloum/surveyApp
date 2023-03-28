using SurveyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.ViewModels
{
    public class SurveyViewModel
    {
        public Person HouseHold { set; get; }
        public List<Person> Members { set; get; }
        public List<int> Answers { set; get; }

        public string? Desc { set; get; }
        public int FamilySize { set; get; }
    }
}
