using static System.Console;
namespace ClassLibrary1
{
    public class A
    {
        public string NombreInstancia { get; set; }
        /*protected string NombreInstancia { get; set; }
        private string NombreInstancia { get; set; }*/
        public A()
        {
            NombreInstancia = "Instancia sin nombre";
        }
        public A(string nombre)
        {
            NombreInstancia = nombre;
        }
        public void MostrarNombre()
        {
            WriteLine($"Nombre de instancia: {NombreInstancia}");
        }
        public void M1()
        {
            WriteLine("Método M1 invocado");
        }
        public void M2()
        {
            WriteLine("Método M2 invocado");
        }
        public void M3()
        {
            WriteLine("Método M3 invocado");
        }
        /*protected void M1()
        {
            WriteLine("Método M1 invocado");
        }
        protected void M2()
        {
            WriteLine("Método M2 invocado");
        }
        protected void M3()
        {
            WriteLine("Método M3 invocado");
        }
        private void M1()
        {
            WriteLine("Método M1 invocado");
        }
        private void M2()
        {
            WriteLine("Método M2 invocado");
        }
        private void M3()
        {
            WriteLine("Método M3 invocado");
        }*/
    }
}
