using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica11
{
    class Program
    {
        static void Main(string[] args)
        {
            int op=0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("**********************************************");
                    Console.WriteLine("         Ejercicios de la practica 11");
                    Console.WriteLine("**********************************************");
                    Console.WriteLine();
                    Console.WriteLine("1-)Ejercicio 1");
                    Console.WriteLine("2-)Ejercicio 2");
                    Console.WriteLine("3-)Ejercicio 3");
                    Console.WriteLine("4-)Salir");
                    Console.WriteLine();
                    op = Convert.ToInt32(Console.ReadLine());
                    switch (op)
                    {
                        case 1:
                            ejercicio1 ejer1 = new ejercicio1();
                            ejer1.Ejercicio_1();
                            break;
                        case 2:
                            ejercicio2 ejer2 = new ejercicio2();
                            ejer2.Ejercicio_2();
                            break;
                        case 3:
                            ejercicio3 ejer3 = new ejercicio3();
                            ejer3.Ejercicio_3();
                            break;
                        case 4:
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.Clear();
                    Console.WriteLine("La opción ingresada es incorrecta");
                    Console.WriteLine();
                    Console.WriteLine("Presione cualquier tecla");
                    Console.ReadKey();
                }
            } while (op!=4);
        }
    }
}
