using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SueldoEmpleados
{
    public class Program
    {
        static void Main(string[] args)
        {
            int cantidadempleados = 0;
            int empleadosSueldoBajo = 0;
            int empleadosSueldoAlto = 0;
            decimal totalSueldos = 0;
            decimal sueldo = 0;

            try
            {
                Console.WriteLine("ingrese la cantidad de empleados: ");
                cantidadempleados = Convert.ToInt32(Console.ReadLine());

                for (int i = 0; i < cantidadempleados; i++)
                {
                    Console.WriteLine($"ingrese el sueldo del empelado {i + 1}: ");
                   decimal Sueldo = Convert.ToInt32(Console.ReadLine());
                }
                totalSueldos += sueldo;

                if (sueldo <= 300)
                {
                    empleadosSueldoBajo++;
                }
                else
                {
                    empleadosSueldoAlto++;
                }
                Console.WriteLine($"empleados con sueldos entre 100 y 300: {empleadosSueldoBajo}");

                Console.WriteLine($"empleados con sueldo mayor a 300: {empleadosSueldoAlto}");

                Console.WriteLine($"total sueldos: ${totalSueldos}");
            }
            
            catch (Exception)
            {
                Console.WriteLine("ocurrio un error:");
                
            }
        }
    }
}
