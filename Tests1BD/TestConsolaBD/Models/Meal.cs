using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaBD
{
    public class Meal
    {

        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        [Key] public int  ID {  get; set; }
        public required string  Name { get; set; }
        public required int Kcal {  get; set; }
        public int? Weight {  get; set; }
        public int Protein { get; set; }
        public int Carbohydrate { get; set; }
        public int Fat { get; set; }
        public DateOnly Date { get; set; }
        public int MealTypeID { get; set; }
        public required int UserID { get; set; }

        //propiedad navegacion

        public required User User { get; set; }
        public required MealType MealType { get; set; }
    }
}
