using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class Program
    {
        static void Main(string[] args)
        {
            //test();
            TestProdottiInOfferta();
        }

        private static void TestProdottiInOfferta()
        {
            throw new NotImplementedException();
        }

        private static void test()
        {
            Console.WriteLine("Inserisci il nome del negozio: ");
            string nome_negozio = Console.ReadLine();
            Console.WriteLine("Inserisci il proprietario del negozio: ");
            string prop = Console.ReadLine();

            Console.WriteLine("Inserisci prodotto/i: ");
            string line="";
            int counter = 0;
            List<Prodotto> ListaProdotti = new List<Prodotto>();
            
            while (line != null && counter<2)
            {
                line= Console.ReadLine();
                String[] res = line.Split(new char[] { ' ' });

                if (res.Length == 1)
                {
                    Prodotto prodotto = new Prodotto(res[0]);
                }

                if (res.Length == 2)
                {
                    int cod = Convert.ToInt32(res[0]);
                    Prodotto prodotto = new Prodotto(cod, res[1]);
                }

                if (res.Length == 3)
                {
                    double price = Convert.ToDouble(res[1]);
                    double discount = Convert.ToDouble(res[2]);
                    Prodotto prodotto = new Prodotto(res[0], price, discount);
                }

                if (res.Length == 4)
                {
                    int cod = Convert.ToInt32(res[0]);
                    double price = Convert.ToDouble(res[2]);
                    double discount = Convert.ToDouble(res[3]);
                    Prodotto prodotto = new Prodotto(cod, res[1], price, discount);
                    
                    
                    ListaProdotti.Add(prodotto);                    
                }
                counter++;
            }

            Negozio neg = new Negozio(nome_negozio, prop, ListaProdotti);

            Console.WriteLine("\r\nIl negozio {0} di {1} ha i seguenti prodotti:", neg.Nome, neg.Proprietario);
            foreach (Prodotto c2 in ListaProdotti)
            {
                System.Console.Write(c2.ToString());
                Console.WriteLine("\r\n");
            }
            System.Console.ReadLine();
           
        }
    }
}
