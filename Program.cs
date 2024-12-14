using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SwitchSemana
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Introduce un número");
            string input = Console.ReadLine();
            int.TryParse(input, out int result);

            if (result > 0 && result <= 7)
            {
                switch (result)
                {

                    case 1:
                        Console.WriteLine("Hoy es Lunes");
                        break;
                    case 2:
                        Console.WriteLine("Hoy es Martes");
                        break;
                    case 3:
                        Console.WriteLine("Hoy es Miercoles");
                        break;
                    case 4:
                        Console.WriteLine("Hoy es Jueves");
                        break;
                    case 5:
                        Console.WriteLine("Hoy es Viernes");
                        break;
                    case 6:
                        Console.WriteLine("Hoy es Sabado");
                        break;
                    case 7:
                        Console.WriteLine("Hoy es Domingo");
                        break;

                    default:
                        Console.WriteLine("No se que dia es...");
                        break;

                }
            }
            else
            {
                Console.WriteLine("Dato Incorrecto");
            }
        }
    }
}
