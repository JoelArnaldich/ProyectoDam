using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaBD
{
    public class Objective
    {


        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int ID { get; set; }

        public bool LoseWeight { get; set; } = false;

        public bool LoseWeightWinMuscle { get; set; } = false;

        public bool WinMuscleWinWeight { get; set; } = false;

        public int GoalWeight { get; set; }


        //propiedad navegacion
        public required User User { get; set; }



    }
}
