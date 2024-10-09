using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaBD
{
    public class DialyWater
    {

      [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
      [Key] public int ID {  get; set; }
      public int WaterLiter { get; set; }
      public DateOnly Date {  get; set; }
      public required int UserID { get; set; }

        //propiedad navegacion
        public required User User { get; set; }  
    }
}
