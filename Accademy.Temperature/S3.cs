﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static Accademy.Temperature.Termometro;

namespace Accademy.Temperature
{
    public class S3
    {
        private Termometro _term;
        public S3(Termometro term)
        {
            this._term = term;
            TermometroEventHandler del = new TermometroEventHandler(term_TemperatureTooHigh); //costruzione del delegate
            this._term.TemperatureTooHigh += del; //invoco add_MailArrived(del)
        }

        public void term_TemperatureTooHigh(Object sender, double temp)
        {
            Console.WriteLine("Subscriber 3: La temperatura registrata e': {0}", temp);
        }
    }
}
