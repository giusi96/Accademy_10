using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    public class MailEvevenArgs
    {
        public string From { get; set; }
        public string To { get; set; }
        public string obj { get; set; }
        public string Body { get; set; }
    }
    //object sender-> colui che ha sollevato l'evento
    public delegate void MailManagerEventHandler(Object sender, MailEvevenArgs args);

}
