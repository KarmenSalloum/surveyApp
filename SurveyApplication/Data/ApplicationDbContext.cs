using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using SurveyApplication.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace SurveyApplication.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Person> Persons { set; get; }
        public DbSet<Answer> Answers { set; get; }
        public DbSet<PersonAnswer> PersonAnswers { set; get; }
    }
}
