using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaBD
{
    public class Meals
    {
        public int  Id_meal {  get; set; }
        public required string  Name { get; set; }
        public required int Kcal {  get; set; }
        public string? Meal_Type  { get; set; }
        public int? Weight {  get; set; }
        public int Protein { get; set; }
        public int Carbohydrates { get; set; }
        public int Fats { get; set; }



    }
}
