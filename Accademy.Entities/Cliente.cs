using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Entities
{
   public class Cliente
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string CF { get; set; }
        public string Username { get; set; }
        public ContoCorrente mioConto { get; set; }
       

    }
}
