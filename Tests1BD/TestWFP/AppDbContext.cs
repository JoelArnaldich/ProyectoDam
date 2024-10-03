using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaBD
{
    public class AppDbContext : DbContext
    {

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=master;Trusted_Connection=True;");
        }

        public DbSet<User> Users { get; set; }
        public DbSet<Meal> Meals { get; set; }
        public DbSet<DialyExercise> dialyExercises { get; set; }
        public DbSet<DialyWater> DialyWater { get; set; }
        public DbSet<Objective> objectives { get; set; }
        public DbSet<AnswerIA> answerIAs { get; set; }

    }
}
