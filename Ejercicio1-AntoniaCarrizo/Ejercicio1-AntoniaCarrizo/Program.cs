using System;
using System.IO;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;

namespace Ejercicio1AntoniaCarrizo
{
    class MainClass
    {
        public static void Main(string[] args)
        {

            while (true)
            {
                Console.WriteLine("Seleccione: ");
                Console.WriteLine("1) Crear Persona para almacenar");
          
                Console.WriteLine("2) Salir");
                int op = Convert.ToInt32(Console.ReadLine());

                if (op == 1)
                {

                    Console.WriteLine("Nombre: ");
                    string nombre = Console.ReadLine();
                    Console.WriteLine("Apellido: ");
                    string apellido = Console.ReadLine();
                    Console.WriteLine("Edad: ");
                    int edad = Convert.ToInt32(Console.ReadLine());
                    Person persona = new Person(nombre, apellido, edad);
                    if (Almacenar(persona) == true)
                    {
                        Console.WriteLine("Persona almacenada");
                    }
                    
                }
               
                else if (op==2)
                {
                    break;
                }
                else
                {
                    Console.WriteLine("opcion novalida vuelva a ingresarla");
                }
            }
            bool Almacenar(Person person)
            {
                IFormatter formatter = new BinaryFormatter();
                Stream stream = new FileStream("MyFile.bin", FileMode.Create, FileAccess.Write, FileShare.None);
                formatter.Serialize(stream, person);
                stream.Close();
                return true;
            }
            



            

       
        }
    }
}
