using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace SurveyApplication.Models
{
    public class PersonAnswer
    {
        [Key]
        public int PersonAnswerId { set; get; }
        public int PersonId { set; get; }
        public int AnswerId { set; get; }

        public string? Desc { set; get; }

        public virtual Person Person { set; get; }
        public virtual Answer Answer { set; get; }
    }
}
