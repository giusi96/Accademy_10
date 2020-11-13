using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Helper
{
    public class Helper 
    {
        /// <summary>
        /// Get a random value in a range
        /// </summary>
        /// <param name="min">min range value</param>
        /// <param name="max">max range value</param>
        /// <exception cref="Accademy.Helper.RandomArgumentsException">Thrown when min value is greater then max value</exception>
        /// <returns>random int in a range</returns>
        /// 

        public static int ConvertBinaryToint(string binarystring)
        {
            //verificare che la stringa contenga solo 0 e 1, altrimenti restituire -1
            char [] array= binarystring.ToCharArray();
            Array.Reverse(array);
            int result = 0;
            for (int i = 0; i <array.Length; i++)
            {
                if(array[i]=='0' || array[i]=='1')
                {
                    int num = Convert.ToInt32(array[i])-48;
                    int potenza = (int)(Math.Pow(2,i));
                    result +=num * potenza;                  
                }
                else
                    return -1;
            }
            return result;
        }
        public static int GetRandomInt(int min, int max)
        {
            if (min > max)
            {
                throw new RandomArgumentsException();
            }
            else
            {
                int seed = Guid.NewGuid().GetHashCode(); //mi serve per avere un seme in Random altrimenti mi stamperebbe sempre gli stessi numeri
                                                         //alternativa: mettere come seme l'ora del PC
                Random r = new Random(seed);
                return r.Next(min, max);
            }
        }
        public static double GetRandomDouble(double min, double max)
        {
            if (min > max)
            {
                throw new RandomArgumentsException();
            }
            else
            {
                int seed = Guid.NewGuid().GetHashCode(); //mi serve per avere un seme in Random altrimenti mi stamperebbe sempre gli stessi numeri
                                                         //alternativa: mettere come seme l'ora del PC
                Random r = new Random(seed);
                return r.NextDouble() *(max-min)+min;
            }
        }
        public static int GetSameInt(int sameint)
        {
            return sameint;
        }

        public static string GetNumConto(int numChars)
        {
            string cc = "";
            if (numChars<=36)
            {
                Guid newGuid = Guid.NewGuid();
                string s_newGuid = newGuid.ToString();
                cc = s_newGuid.Substring(0, numChars);
            }

            return cc;            
        }
    }
}
