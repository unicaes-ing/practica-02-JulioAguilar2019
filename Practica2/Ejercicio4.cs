using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class Ejercicio4
    {
        static void Main(string[] args)
        {
            DateTime fechaEntrada, fechaSalida;
            double valorDia, totalPagar;


            Console.WriteLine("Ingrese la fecha de inicio: (dia/mes/año)");
            fechaEntrada = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese la fecha de devolución: (dia/mes/año)");
            fechaSalida = Convert.ToDateTime(Console.ReadLine());
            Console.WriteLine("Ingrese el valor por dia del alquiler");
            valorDia = Convert.ToDouble(Console.ReadLine());
            TimeSpan dias = fechaSalida - fechaEntrada;
            Console.WriteLine("El total de dias transcurridos es: " + dias.TotalDays);
            int dia = dias.Days;
            totalPagar = valorDia * dia;
            Console.WriteLine(string.Format("El monto total a cancelar es de: {0:C1}", totalPagar));
            Console.ReadKey();



        }
    }
}
