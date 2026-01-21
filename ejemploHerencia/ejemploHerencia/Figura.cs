using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejemploHerencia
{
    internal abstract class Figura
    {
        double Posx;
        double Posy;


        protected Figura(double posx, double posy)
        {
            Posx = posx;
            Posy = posy;
        }


        public abstract double CalcularArea();

    }
}
