using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Esercitazione
{
    public class Negozio
    {
        public string Nome { get; set; }
        public string Proprietario { get; set; }

        public List<Prodotto> Prodotti_list { get;}

        public Negozio(string nome, string proprietario)
        {
            this.Nome = nome;
            this.Proprietario = proprietario;
            Prodotti_list = new List<Prodotto>();
        }

        public Negozio(string nome, string proprietario, List<Prodotto> lst)
        {
            this.Nome = nome;
            this.Proprietario = proprietario;
            this.Prodotti_list = lst;           
        }

    }
}
