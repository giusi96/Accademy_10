using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.MailSystem
{
    public class MailManager
    {
        public event MailManagerEventHandler MailArrived;
        public void SimulateMailArrived(string from, string to, string obj, string body)
        {
            MailEvevenArgs args = new MailEvevenArgs()
            {
                Body = body,
                From = from,
                To = to,
                obj = obj

            };
            
            ////primometodo
            //MailArrived?.Invoke(this, args);

            ////metodo
            //if (MailArrived != null)
            //{
            //    MailArrived(this, args);
            //}
            

            //metodo esplicito
            if (MailArrived!= null)
            {
                foreach (var item in MailArrived.GetInvocationList().ToList())
                {
                    MailManagerEventHandler mm_eh = (MailManagerEventHandler)item;
                    mm_eh(this, args);
                   } 
            }
        }
    }
}
