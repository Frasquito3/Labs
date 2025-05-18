using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace AdivineNumero
{
    public class JugadaConAyuda : Jugada
    {
        public JugadaConAyuda(int maxNumero) : base(maxNumero) { }

        public override string Comparar(int intento)
        {
            string mensaje = base.Comparar(intento);
            int diferencia = Math.Abs(intento - Numero);
            Console.Clear();

            if (intento == Numero)
            {
                return mensaje;
            }

            if (diferencia > 20)
            {
                mensaje += " Ademas está muy lejos.";
            }
            else if (diferencia <= 5)
            {
                mensaje += " Ademas está muy cerca.";
            }

            return mensaje;
        }
    }
}
