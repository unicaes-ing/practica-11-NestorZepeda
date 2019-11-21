using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica11
{
    class ejercicio1
    {
        public void Ejercicio_1()
        {
            string nombre, telefon,fecha;
            decimal salario;
            try
            {
                Console.Clear();
                Console.WriteLine("Ingrese datos del cliente");
                Console.WriteLine();
                Console.WriteLine("Nombre: ");
                nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Telefono:");
                telefon = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Fecha de nacimiento:");
                fecha = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Salario: ");
                salario = Convert.ToDecimal(Console.ReadLine());
                FileStream stream = new FileStream("datos.bin", FileMode.OpenOrCreate, FileAccess.Write);
                BinaryWriter datos = new BinaryWriter(stream);
                datos.Write(nombre);
                datos.Write(telefon);
                datos.Write(fecha);
                datos.Write(salario);
                stream.Close();
                datos.Close();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Los datos han sido guardados correctamente");
                Console.ReadKey();
            }
            catch (Exception)
            {

                Console.WriteLine("Error al guardar archivo");
            }
        }
    }
}
