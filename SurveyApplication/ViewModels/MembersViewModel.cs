using SurveyApplication.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.ViewModels
{
    public class MembersViewModel
    {
        public int num { set; get; }
        public List<Person> members { set; get; }
    }
}
