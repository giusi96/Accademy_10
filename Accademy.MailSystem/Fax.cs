using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    public class Fax
    {
        private MailManager _mm; //proprietà di solo lettura di Fax
        public Fax(MailManager mm)
        {
            this._mm = mm;
            MailManagerEventHandler del = new MailManagerEventHandler(mm_MailArrived); //costruzione del delegate
            this._mm.MailArrived += del; //invoco add_MailArrived(del)
        }

        public void mm_MailArrived(Object sender, MailEvevenArgs args)
        {
            Console.WriteLine("I'm a Fax \r\n Mail From {0}, Mail To {1} \r\n obj:{2} \t\t Body: {3}", 
                args.From, args.To, args.obj, args.Body);
        }
    }
}
