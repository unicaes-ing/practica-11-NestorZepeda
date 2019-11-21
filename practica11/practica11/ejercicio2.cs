using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica11
{
    class ejercicio2
    {
        public void Ejercicio_2()
        {
            try
            {
                FileStream stream = new FileStream("datos.bin", FileMode.Open, FileAccess.Read);
                BinaryReader datos = new BinaryReader(stream);
                string nombre = datos.ReadString();
                string telefono = datos.ReadString();
                string fecha = datos.ReadString();
                decimal salario = datos.ReadDecimal();
                stream.Close();
                datos.Close();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("**************************");
                Console.WriteLine("    Datos del Cliente");
                Console.WriteLine("**************************");
                Console.WriteLine();
                Console.WriteLine("Nombre del cliente: "+nombre);
                Console.WriteLine();
                Console.WriteLine("Numero de telefono: "+telefono);
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento: "+fecha);
                Console.WriteLine();
                Console.WriteLine("Salario: "+salario.ToString("C2"));
                Console.WriteLine();
                Console.ReadKey();

            }
            catch (Exception)
            {
                Console.WriteLine("Error al encontrar los archivos");
                Console.ReadKey();
            }
           
        }
    }
}
