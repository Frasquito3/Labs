using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdivineNumero
{
    public class Jugada
    {
        private bool adivino;
        private int intentos;
        private int numero;

        public int Intentos => intentos;
        public bool Adivino => adivino;
        public int Numero
        {
            get => numero;
            set => numero = value;
        }

        public Jugada (int maxNumero)
        {
            Random rnd = new Random ();
            Numero = rnd.Next(maxNumero);
            intentos = 0;
            adivino = false;
        }

        public string Comparar(int intentos)
        {
            intentos++;

            if (intentos == numero)
            {
                adivino = true;
                return "¡Correcto! Adivinaste el número.";
            }
            else if (intentos < numero)
            {
                return "El número es mayor.";
            }
            else
            {
                return "El número es menor.";
            }
        }
    }
}
