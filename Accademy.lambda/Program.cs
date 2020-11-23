using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.lambda
{
    public delegate bool FilterInt(int i); //dichiarazione di un delegate
    public delegate bool MyDelegate(int i, string s);
    public delegate bool NewDelegate();
    public class Program
    {
        static void Main(string[] args)
        {
            List<int> lst = new List<int> { 0, 1, 2, 3, 4, 5, 6, 7, 8, 9 }; //costruisco una lista di interi
            FilterInt filterOdd = new FilterInt(IsOdd);//costruisco un delegate con dentro un metodo ben preciso
            //List<int> result = FilterInts(lst, filterOdd); //invoco il delegate passandogli i parametri
            //List<int> result2 = FilterInts(lst, IsEven);
          
            //MyDelegate lambda = (i, s) =>
            //{
            //     if (i > s.Length)
            //         return true;
            //     else
            //         return false;
            //};
            
            //NewDelegate new_lambda = () => { return true; };

            //List<int> result = FilterInts(lst, i => (i % 2) == 1); //lambda expression

            List<int> result = FilterInts(lst, i => (i & 1) == 1);//altro modo con l'&: fa l'end bit a bit

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }

        public static bool IsOdd(int x)
        {
            return (x % 2) == 1;

        }
        public static bool IsEven(int x)
        {
            return (x % 2) == 0;

        }

        //ti do una lista di interi, mi restituisci la lista filtrata
        public static List<int> FilterInts(List<int> inputlst, FilterInt filter) 
        {
            List<int> resultList = new List<int>(); //lista vuota
            foreach (var item in inputlst)                              
            {
                if(filter(item)) //ivoco il metodo IsOdd
                {
                    resultList.Add(item); //qui avrò solo i numeri dispari
                }
            }
            return resultList;
        }
    }

   
}
