using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class ProdottiOfferta : Prodotto
    {
        public  DateTime dt1 { get; set; }
        public DateTime dt2 { get; set; }

        public ProdottiOfferta( string descrizione) :
             base( descrizione)
        {

        }
        public ProdottiOfferta(int codice, string descrizione) :
            base (codice, descrizione)
            {

            }

        public ProdottiOfferta(string descrizione, double prezzo, double sconto) :
            base(descrizione, prezzo, sconto)
        {

        }

        public ProdottiOfferta(int codice, string descrizione, double prezzo, double sconto) :
            base(codice, descrizione, prezzo, sconto)
        {

        }

    }
}
