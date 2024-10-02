using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TestConsolaBD
{
    public class Users
    {
        public int Id_user {  get; set; }

        public int Height {  get; set; }  

        public int Weight { get; set; }

        public required string Username { get; set; }
        public required string Password { get; set; }
        public required string Email { get; set; }



    }
}
