namespace Clases
{
    public class Persona
    {
        private string nombre;
        private string apellido;
        private string dni;
        private int edad;

        public Persona(string nombre, string apellido, int edad, string dni)
        {
            this.nombre = nombre;
            this.apellido = apellido;
            this.dni = dni;
            this.edad = edad;
            Console.WriteLine("Persona creada correctamente");
        }
        ~Persona()
        {
            Console.WriteLine("Persona destruida correctamente");
        }

        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return Apellido; }
            set { Apellido = value; }
        }
        public string Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Edad
        {
            get { return edad.ToString(); }
            set { edad = int.Parse(value); }
        }

        public string getFullName()
        {
            return $"{nombre} {apellido}";
        }
        public string getAge()
        {
            return $"{edad}";
        }
    }
}
