using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Accademy.GeometryAbstract
{
    public abstract class FiguraGeometrica //classe astratta
    {
        public abstract double GetArea();
        public abstract double GetPerimetro();

        public string GetDescription() //metodo non astratto
        {
            Type t = this.GetType(); //per dirmi in che istanza mi trovo
            string myType = t.ToString();

            string description = "I'm a " + myType +" with Area: " + GetArea() + " Perimetro: " + GetPerimetro();
            return description;
        }
    }
}
