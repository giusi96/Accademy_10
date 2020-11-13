using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    class Program
    {
        static void Main(string[] args)
        {
            MailManager mm = new MailManager();
            Fax fax = new Fax(mm);
            Printer prn = new Printer(mm);

            mm.SimulateMailArrived("topolino", "Minni", "Cena", "Usciamo stasera?");
            mm.SimulateMailArrived("Minni", "topolino", "Cena", "No, non esco");
        }
    }
}
