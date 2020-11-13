using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    public class Printer
    {
        MailManager _mm;

        public Printer(MailManager mm)
        {
            this._mm = mm;
            this._mm.MailArrived += _mm_MailArrived;
        }

        private void _mm_MailArrived(object sender, MailEvevenArgs args)
        {
            Console.WriteLine("I'm a Printer \r\n Mail From {0}, Mail To {1} \r\n obj:{2} \t\t Body: {3}",
               args.From, args.To, args.obj, args.Body);
            Console.ReadLine();
        }
    }

}
