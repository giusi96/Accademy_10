using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    public class Termometro
    {
        public delegate void TermometroEventHandler(Object sender, double args);
        public event TermometroEventHandler TemperatureTooHigh;

        public void SimulateTemp(double temp)
        {
            if (TemperatureTooHigh != null && temp>25)
            {
                foreach (var item in TemperatureTooHigh.GetInvocationList().ToList())
                {
                    TermometroEventHandler temp_eh = (TermometroEventHandler)item;
                    temp_eh(this, temp);
                }
            }
            else
                Console.WriteLine("Temperature is lower than 25");
        }
    }
}
