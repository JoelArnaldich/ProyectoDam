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
      public DateTime Date {  get; set; }

      //propiedad navegacion
      public User User { get; set; }  
    }
}
