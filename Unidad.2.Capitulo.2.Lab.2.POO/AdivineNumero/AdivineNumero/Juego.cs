namespace AdivineNumero
{
    public class Juego
    {
        private int record = int.MaxValue;

        public void ComenzarJuego()
        {
            string seguir;

            do
            {
                int maxNumero = PreguntarMaximo();
                Jugada jugada = new JugadaConAyuda(maxNumero);

                Console.Clear();
                Console.WriteLine("Adiviná el número...");

                while (!jugada.Adivino)
                {
                    int intento = PreguntarNumero();
                    string resultado = jugada.Comparar(intento);
                    Console.WriteLine(resultado);
                }

                Console.WriteLine($"¡Adivinaste en {jugada.Intentos} intentos!\n");
                CompararRecord(jugada.Intentos);

                seguir = Continuar();

            } while (seguir.ToLower() == "s");
        }

        public void CompararRecord(int intentos)
        {
            if (intentos < record)
            {
                record = intentos;
                Console.WriteLine($"¡Nuevo récord!");
            }
            else
            {
                Console.WriteLine($"Tu récord es de {record} intentos.");
            }
        }

        public string Continuar()
        {
            Console.Write("\n¿Querés jugar de nuevo? (s/n): ");
            string? vali = Console.ReadLine();
            return vali;

        }

        public int PreguntarMaximo()
        {
            while (true)
            {
                try
                {
                    Console.Clear();
                    Console.Write("Ingresá el número máximo posible: ");
                    int maximo = int.Parse(Console.ReadLine());
                    return maximo;
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Ingresá un número válido.\n");
                }
            }
        }

        public int PreguntarNumero()
        {
            while (true)
            {
                try
                {
                    Console.Write("\nIngresá un número: ");
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("\nError: Ingresá un número válido.\n");
                }
            }
        }
    }
}
