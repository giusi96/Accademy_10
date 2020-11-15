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
            Console.OutputEncoding = System.Text.Encoding.UTF8;
            TestProdotti();
            //TestProdottiInOfferta();
        }
        
        private static void TestProdottiInOfferta()
        {
            Console.WriteLine("Inserisci il nome del negozio: ");
            string nome_negozio = Console.ReadLine();
            Console.WriteLine("Inserisci il proprietario del negozio: ");
            string prop = Console.ReadLine();
            Console.WriteLine("Inserisci prodotto/i in offerta: ");
           
            List<Prodotto> ListaProdotti_Offerta = new List<Prodotto>();

            ProdottiOfferta pO1 = new ProdottiOfferta(1, "pasta", 0.98, 0.10, new DateTime(2020,11, 12), new DateTime(2020,11,14));
            ProdottiOfferta pO2 = new ProdottiOfferta(2, "farina", 0.68, 0.10, new DateTime(2020, 11, 15), new DateTime(2020, 11, 18));
            ProdottiOfferta pO3 = new ProdottiOfferta(3, "carne", 6.90, 0.15, new DateTime(2020, 11, 10), new DateTime(2020, 11, 14));

            ListaProdotti_Offerta.Add(pO1);
            ListaProdotti_Offerta.Add(pO2);
            ListaProdotti_Offerta.Add(pO3);

            bool prodisinofferta = false;

            string dataoggi = DateTime.Now.ToString("dd-MM-yyyy");
            Console.WriteLine("I prodotti in offerta oggi, {0}," +
                "\r\n al negozio {1} di {2} sono:", dataoggi, nome_negozio, prop);
                
            foreach (ProdottiOfferta item in ListaProdotti_Offerta)
            {
                if (item.dt1< DateTime.Now  && item.dt2.AddDays(1)>DateTime.Now)
                {
                    prodisinofferta = true;                   
                    Console.WriteLine("\r\n" + item.ToString());
                }
            }

            if(prodisinofferta==false)
                Console.WriteLine("\r\n Non ci sono prodotti in offerta oggi.");
            Console.ReadLine();
        }

        private static void TestProdotti()
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

                    ListaProdotti.Add(prodotto);
                }

                if (res.Length == 2)
                {
                    int cod = Convert.ToInt32(res[0]);
                    Prodotto prodotto = new Prodotto(cod, res[1]);

                    ListaProdotti.Add(prodotto);
                }

                if (res.Length == 3)
                {
                    double price = Convert.ToDouble(res[1]);
                    double discount = Convert.ToDouble(res[2]);
                    Prodotto prodotto = new Prodotto(res[0], price, discount);

                    ListaProdotti.Add(prodotto);
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
