using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CEscalonaEmpleado
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Empleado empleado = new Empleado();


            bool salir = false;
            while (!salir)
            {
                Console.WriteLine("Bienvenido al Menu");
                Console.WriteLine("1. Empleado 1 ");
                Console.WriteLine("2. Empleado 2 ");
                Console.WriteLine("3. Empleado 3 ");

                Console.WriteLine("5. Salir");

                int opcion = Convert.ToInt32(Console.ReadLine());

                switch (opcion)
                {
                    case 1:
                        Console.WriteLine("Nombre: {0}", empleado.Nombre);
                        Console.WriteLine("Apellido: {0}", empleado.Apellido);
                        Console.WriteLine("Salario Duario: {0}", empleado.SueldoDirio);


                        break;
                    case 2:
                        Console.WriteLine("Nombre: {0}", empleado.Nombre1);
                        Console.WriteLine("Apellido: {0}", empleado.Apellido1);
                        Console.WriteLine("Salario Duario: {0}", empleado.SueldoDirio1);

                        break;
                    case 3:
                        Console.WriteLine("Nombre: {0}", empleado.Nombre2);
                        Console.WriteLine("Apellido: {0}", empleado.Apellido2);
                        Console.WriteLine("Salario Duario: {0}", empleado.SueldoDirio2);


                        break;
                    case 4:
                        Console.WriteLine("Has elegido salir de la aplicación");
                        salir = true;
                        break;
                    default:
                        Console.WriteLine("Elige una opcion entre 1 y 4");
                        break;
                }

            }
        
    }
    }
}
