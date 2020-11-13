using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class Prodotto
    {
        public int Codice { get; set; }
        public string Descrizione { get; set; }
        public double Prezzo { get; set; }
        public double Sconto { get; set; }


        public Prodotto(int codice, string descrizione, double prezzo, double sconto)
        {
            this.Codice = codice;
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Sconto = sconto * 100;
        }

        public Prodotto(string descrizione, double prezzo, double sconto)
        {
            this.Descrizione = descrizione;
            this.Prezzo = prezzo;
            this.Sconto = sconto*100;
            this.Codice = -1;
        }

        public Prodotto(int codice, string descrizione)
        {
            this.Codice = codice;
            this.Descrizione = descrizione;
            this.Prezzo = 0;
            this.Sconto = 0;
        }

        public Prodotto(string descrizione)
        {
            this.Descrizione = descrizione;         
        }

        public override string ToString()
        {
            return Codice+"\t"+Descrizione+"\t"+ Prezzo+ "\t"+ Sconto;
        }
    }
}
