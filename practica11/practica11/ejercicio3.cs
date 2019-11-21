using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practica11
{
    class ejercicio3
    {
        public void Ejercicio_3()
        {
            int dec;
            do
            {
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("1-)Agregar alumno");
                Console.WriteLine();
                Console.WriteLine("2-)Mostrar alumno");
                Console.WriteLine();
                Console.WriteLine("3-)Buscar alumno");
                Console.WriteLine();
                Console.WriteLine("4-)Salir");
                dec = Convert.ToInt32(Console.ReadLine());
                switch (dec)
                {
                    case 1:
                        agregar();
                        break;
                    case 2:
                        mostrar();
                        break;
                    case 3:
                        break;
                    default:
                        break;
                }
            } while (dec!=4);
            
        }

        int numreg = 0;
        int anchoreg = 15 + 20 + 8 + 8;
        #region agregar
        public void agregar()
        {
            FileStream stream = new FileStream("datosestudiante.bin", FileMode.OpenOrCreate, FileAccess.ReadWrite);
            BinaryWriter datos = new BinaryWriter(stream);
           
          
            try
            {
                
                numreg = Convert.ToInt32(Math.Ceiling((decimal)stream.Length / anchoreg));
                datos.BaseStream.Seek(numreg*anchoreg, SeekOrigin.Begin);
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("***********************************");
                Console.WriteLine("     Ingrese datos del alumno");
                Console.WriteLine("***********************************");
                Console.WriteLine();
                Console.WriteLine("Carnet: ");
                string carnet = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Nombre:");
                string nombre = Console.ReadLine();
                Console.WriteLine();
                Console.WriteLine("Edad:");
                int edad = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine();
                Console.WriteLine("CUM: ");
                decimal cum = Convert.ToDecimal(Console.ReadLine());
                Console.WriteLine();
                
                datos.Write(carnet);
                datos.Write(nombre);
                datos.Write(edad);
                datos.Write(cum);
                stream.Close();
                datos.Close();
                Console.Clear();
                Console.WriteLine();
                Console.WriteLine("Los datos se han guardado correctamente");
                Console.WriteLine();
                Console.WriteLine("Presione cualquier tecla para regresar al inicio");
                Console.ReadKey();
            }
            catch (Exception)
            {
                Console.WriteLine("Error al guardar datos");
              
            }
            


        }
        #endregion
        #region mostrar
        public void mostrar()
        {
            FileStream leer= new FileStream("datosestudiante.bin", FileMode.Open, FileAccess.Read);
            BinaryReader bleer = new BinaryReader(leer);
            int anchoreg = 15 + 20 + 8 + 8;
            numreg = Convert.ToInt32(Math.Ceiling((decimal)leer.Length / anchoreg));
            bleer.BaseStream.Seek(0, SeekOrigin.Begin);
            int dec=0;
            do
            {
                try
                {
                    Console.Clear();
                    Console.WriteLine();
                    Console.WriteLine("*******************************");
                    Console.WriteLine("         Mostrar alumnos");
                    Console.WriteLine("*******************************");
                    Console.WriteLine();
                    Console.WriteLine("1-)Todos los alumnos");
                    Console.WriteLine();
                    Console.WriteLine("2-)Filtrado por CUM");
                    Console.WriteLine();
                    Console.WriteLine("3-)Volver");
                    Console.WriteLine();
                    dec = Convert.ToInt32(Console.ReadLine());
                    switch (dec)
                    {
                        case 1:
                          
                            try
                            {
                                numreg = Convert.ToInt32(Math.Ceiling((decimal)leer.Length / anchoreg));
                                bleer.BaseStream.Seek(0, SeekOrigin.Begin);
                                Console.Clear();
                                string carnet,nombre;
                                int edad;
                                 decimal cum;
                                Console.Clear();
                                Console.WriteLine();
                                Console.WriteLine("Datos de los alumnos");
                                Console.WriteLine();
                                Console.WriteLine("{0,-15}{1,-20}{2,-8}{3,-8}","Carnet","     Nombre","  Edad","  CUM");
                                Console.WriteLine("==============================================================");
                                int num=1;
                                do
                                {
                                    carnet = bleer.ReadString();
                                    nombre = bleer.ReadString();
                                    edad = bleer.ReadInt32();
                                    cum = bleer.ReadInt32();
                                    Console.Write("{0,-16}",carnet);
                                    Console.Write("{0,-21}" ,nombre);
                                    Console.Write("{0,-9}",edad);
                                    Console.Write("{0,-9}", cum);
                                    Console.WriteLine();
                                    bleer.BaseStream.Seek(num * anchoreg, SeekOrigin.Begin);
                                    num++;
                                    
                                } while (true);
                                
                            }
                            catch (Exception)
                            {
                            }
                            Console.ReadKey();
                            break;
                        case 2:
                            break;
                        default:
                            break;
                    }
                }
                catch (Exception)
                {
                    Console.WriteLine("La opción ingresada es incorrecta");
                }
                finally
                {
                    if (bleer!=null)
                    {
                        bleer.Close();
                    }
                }
                
             
            } while (dec != 3);
        }
        #endregion

        public void buscar()
        {
            Console.Clear();
            Console.WriteLine();
            try
            {
                Console.WriteLine("Busqueda de alumno");
                Console.WriteLine();
                Console.Write("ingrese el nombre: ");
                string nombre = Console.ReadLine();
                
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
