using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class Ejercicio2
    {
        static void Main(string[] args)
        {
            string nombreProducto;
            int cant;
            double precio, subTotal, iva, valorPagar;

            Console.WriteLine("Nombre del producto:");
            nombreProducto = Console.ReadLine();
            Console.WriteLine("Ingrese el precio: ");
            precio = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad: ");
            cant = Convert.ToInt32(Console.ReadLine());
            subTotal = precio * cant;
            Console.WriteLine(string.Format("El subtotal a pagar es: {0:C2}", subTotal));
            iva = subTotal * 0.13;
            valorPagar = subTotal + iva;
            Console.WriteLine(string.Format("El total a pagar es: {0:C2}", valorPagar));
            Console.ReadKey();

        }
    }
}
