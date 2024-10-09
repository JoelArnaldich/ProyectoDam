using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaBD
{
    public class User
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int ID {  get; set; }
        public int? Height {  get; set; }  
        public int? Weight { get; set; }
        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }
        public int? ObjectiveID { get; set; }

        //propiedad navegacion

        public required List<AnswerIA> answersIA { get; set; }
        public required List<Meal> Meals { get; set; }
        public required List<DialyWater> DialyWater { get; set; }
        public required List<DialyExercise> dialy_Exercises { get; set; }
        public required Objective Objective { get; set; }

    }
}
