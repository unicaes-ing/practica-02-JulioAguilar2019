using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class Ejercicio5
    {
        static void Main(string[] args)
        {
            DateTime horaInicio, horaFinal;
            double valorMin, totalPagar;
            Console.WriteLine("Ingrese la hora de inicio de la llamada");
            horaInicio = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la hora final de la llamada");
            horaFinal = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el valor por minuto");
            valorMin = Convert.ToDouble(Console.ReadLine());
            TimeSpan min = horaFinal - horaInicio;        
            Console.WriteLine("El total de minutos transcurridos es: " + min.TotalMinutes);
            double minutos = min.TotalMinutes;
            totalPagar = valorMin * min.TotalMinutes;
            Console.WriteLine(string.Format("El monto total a cancelar es de: {0:C1}", totalPagar));
            Console.ReadKey();

        }
    }
}
