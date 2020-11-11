using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.Geometry
{
    public class Quadrato : IFiguraGeometrica
    {
        private double lato;

        public Quadrato(double lato)
        {
            this.lato = lato;
        }

        public double GetArea()
        {
            return this.lato * this.lato;
        }

        public double GetPerimetro()
        {
            return 4 * this.lato;
        }

    }
}
