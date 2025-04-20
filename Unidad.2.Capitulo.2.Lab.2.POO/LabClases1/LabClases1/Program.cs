using ClassLibrary1;
using static System.Console;

namespace LabClases1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            A a = new A();
            B b = new B();

            a.MostrarNombre();
            /* Al cambiar la accesibilidad a protected o private nos tirara error en los metodos a.M1(), a.M2() y a.M3() ya que no se tendran los permisos para acceder al metodo desde aqui*/
            a.M1();
            a.M2();
            a.M3();

            WriteLine("");

            b.MostrarNombre();
            /* Al cambiar la accesibilidad a protected o private nos tirara error en los metodos b.M1(), b.M2() y b.M3() ya que no se tendran los permisos para acceder al metodo desde aqui pero si tiene nivel protected podremos acceder desde la clase B*/
            b.M1();
            b.M2();
            b.M3();
            b.M4();
        }
    }
}