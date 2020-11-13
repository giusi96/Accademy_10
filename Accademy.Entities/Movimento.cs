using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Entities
{
    public class Movimento
    {
        public TipoMovimento Tipo { get; set; }
        public double Importo { get; set; }
        public DateTime Data { get; set; }
        public string Beneficiario { get; set; }
    }
}
