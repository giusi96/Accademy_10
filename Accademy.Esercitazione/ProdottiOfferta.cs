using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class ProdottiOfferta : Prodotto
    {
        public DateTime dt1 { get; set; }
        public DateTime dt2 { get; set; }

        public ProdottiOfferta(string descrizione) :
             base(descrizione)
        {

        }
        public ProdottiOfferta(int codice, string descrizione) :
            base(codice, descrizione)
        {

        }

        public ProdottiOfferta(string descrizione, double prezzo, double sconto) :
            base(descrizione, prezzo, sconto)
        {

        }

        public ProdottiOfferta(int codice, string descrizione, double prezzo, double sconto, DateTime datainizio, DateTime datafine) :
            base(codice, descrizione, prezzo, sconto)
        {
            this.dt1 = datainizio;
            this.dt2 = datafine;
        }

        public override string ToString()
        {
            return Codice + "\t" + Descrizione + "\t" + Prezzo +  "€" + "\t" + Sconto + "%" + "\t" + dt1.ToString("dd-MM-yyyy") + "\t" + dt2.ToString("dd-MM-yyyy");

        }
    }
}
