using System;

namespace Primeras_Lineas
{
    public class Program
    {
        public static void Main(string[] args)
        {

            //Conseguir las variables accecdiendo desde otra cs
            Variables p1 = new Variables();

            Console.WriteLine("Introduce el ancho de la habitacion:");
            p1.dato1 = Console.ReadLine();

            Console.WriteLine("Introduce el largo de la habitacion:");
            p1.dato2 = Console.ReadLine();
            
            
            //Permite los decimales
            p1.ancho = Convert.ToDouble(p1.dato1);
            p1.largo = Convert.ToDouble(p1.dato2);

            while (p1.dato1 != null && p1.dato2 != null)
            {

                p1.DameArea();
                Console.WriteLine(p1.area);
            }

            Console.ReadKey();

        }
    }
}
