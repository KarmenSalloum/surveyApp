using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.Models
{
    public class Answer
    {
        [Key]
        public int AnswerId { set; get; }
        public string AnswerValue { set; get; }
        public int AnswerMark { set; get; }

        public virtual ICollection<PersonAnswer> PersonAnswers { set; get; }
    }
}
