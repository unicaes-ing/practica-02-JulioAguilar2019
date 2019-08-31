using System;
//Julio Israel Aguilar Melgar
namespace Practica2
{
    class ejercicio1
    {
        static void Main(string[] args)
        {
            string nombre;
            Console.WriteLine("Programa para cambiar las vocales por signos");
            Console.WriteLine("Ingrese una palabra");
            nombre = Console.ReadLine();
            nombre = nombre.Replace("a", "#").Replace("b", "%").Replace("i", "$").Replace("o", "?").Replace("u", "*");
            Console.Clear();
            Console.WriteLine(nombre);
            Console.ReadKey();
        }
    }
}
