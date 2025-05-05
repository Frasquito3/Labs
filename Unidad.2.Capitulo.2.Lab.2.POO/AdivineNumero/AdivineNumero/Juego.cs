namespace AdivineNumero
{
    public class Juego
    {
        private int record = int.MinValue;

        public void ComenzarJuego()
        {
            string seguir;

            do
            {
                int maxNumero = PreguntarMaximo();
                Jugada jugada = new Jugada(maxNumero);

                Console.WriteLine("Adiviná el número...");

                while (!jugada.Adivino)
                {
                    int intento = PreguntarNumero();
                    string resultado = jugada.Comparar(intento);
                    Console.WriteLine(resultado);
                }

                Console.WriteLine($"¡Adivinaste en {jugada.Intentos} intentos!");
                CompararRecord(jugada.Intentos);

                seguir = Continuar();

            } while (seguir.ToLower() == "s");
        }

        public void CompararRecord(int intentos)
        {
            if (intentos < record)
            {
                record = intentos;
                Console.WriteLine("¡Nuevo récord!");
            }
            else
            {
                Console.WriteLine($"Tu récord es de {record} intentos.");
            }
        }

        public string Continuar()
        {
            Console.Write("¿Querés jugar de nuevo? (s/n): ");
            return Console.ReadLine();

        }

        public int PreguntarMaximo()
        {
            while (true)
            {
                try
                {
                    Console.Write("Ingresá el número máximo posible: ");
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingresá un número válido.");
                }
            }
        }

        public int PreguntarNumero()
        {
            while (true)
            {
                try
                {
                    Console.Write("Ingresá un número: ");
                    return int.Parse(Console.ReadLine());
                }
                catch (FormatException)
                {
                    Console.WriteLine("Error: Ingresá un número válido.");
                }
            }
        }
    }
}
