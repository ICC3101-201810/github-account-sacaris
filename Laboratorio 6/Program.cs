using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {
        static void Main(string[] args)
        {
            int z=1;
            while (z != 3)
            {
                Numero a = new Numero();
                Console.WriteLine("Bienvenido:");
                Console.WriteLine("Si desea arrendar un vehiculo presione 1, si desea recibir un vehiculo presione 2, si desea salir presione 3");
                a.setNumero(Console.ReadLine());

                string count = a.getNumero();
                z = Convert.ToInt32(count);

                while (z > 3)
                {
                    Console.WriteLine("Ingrese un numero correcto");
                    a.setNumero(Console.ReadLine());
                    count = a.getNumero();
                    z = Convert.ToInt32(count);
                }

                Console.ReadLine();
                if (z == 1)
                {
                    Console.WriteLine("Ingrese su nombre:");
                    var nombre = Console.ReadLine();
                    Console.WriteLine("Ingrese su rut:");
                    var rut = Console.ReadLine();
                }
                if (z == 2)
                {

                }
                
                Console.WriteLine("El numero es " + a.getNumero());
            }
        }
    }
}
