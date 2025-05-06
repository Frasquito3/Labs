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

        public int Intentos
        {
            get => intentos;
            set => intentos = value;
        }
        public bool Adivino
        {
            get => adivino;
            set => adivino = value;
        }
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

        public Jugada()
        {
        }

        public virtual string Comparar(int max)
        {
            intentos++;

            if (max == numero)
            {
                adivino = true;
                return "\n\n¡Correcto! Adivinaste el número.\n";
            }
            else if (max < numero)
            {
                return "\nEl número es mayor.";
            }
            else
            {
                return "\nEl número es menor.";
            }
        }
    }
}
