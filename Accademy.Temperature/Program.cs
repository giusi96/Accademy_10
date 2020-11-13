using System;
using Accademy.Helper;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Temperature
{
    class Program
    {
        static void Main(string[] args)
        {
            Termometro term = new Termometro();
            S1 s1 = new S1(term);
            S2 s2 = new S2(term);
            S3 s3 = new S3(term);

            for (int i = 0; i < 50; i++)
            {
                double n = Accademy.Helper.Helper.GetRandomDouble(20, 30); //cambiare in double
                term.SimulateTemp(n);
            }
            Console.ReadLine();
        }
    }
}
