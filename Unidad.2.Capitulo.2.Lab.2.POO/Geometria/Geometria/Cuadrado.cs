using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Geometria
{
    public class Cuadrado : Rectangulo
    {
        public double Lado
        {
            get { return Base; }
            set
            {
                Base = value;
                Altura = value;
            }
        }
    }
}