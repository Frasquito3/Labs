using static System.Console;
namespace ClassLibrary1
{
    public class B : A
    {
        public B() : base("Instancia de B") { }
        public void M4()
        {
            /* En el caso de que los metodos tengan nivel protected podremos acceder a ellos desde la clase hijo, pero no podremos llamarlo desde el Program.cs ya que no se tendran los permisos.
             * En el caso de que los metodos tengan nivel private no podremos acceder de ninguna manera a ellos ya que no se tienen los permisos en la clase hijo ni en el Program.cs
            M1();
            M2();
            M3();*/

            WriteLine("Método del hijo invocado");
        }
    }
}
