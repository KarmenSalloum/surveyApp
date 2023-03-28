using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using static SurveyApplication.Helper.Enums;

namespace SurveyApplication.Models
{
    public class Person
    {
        [Key]
        public int PersonId{ set; get; }
        public string PersonName { get; set; }
        public string? PhoneNumber { get; set; }
        public string? IdNumber { get; set; }
        public Gender PersonGender { get; set; }
        public bool HasDisability { set; get; }
        public bool IsHouseHold { set; get; }
        public int? ParentId { set; get; }
        public DateTime BirthDate { set; get; }

        public virtual Person Parents { set; get; }
        public virtual ICollection<Person> Members { set; get; }
        public virtual ICollection<PersonAnswer> PersonAnswers { set; get; }

    }
}
