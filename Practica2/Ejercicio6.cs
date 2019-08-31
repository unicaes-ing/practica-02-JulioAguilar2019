using System;
using System.Collections.Generic;
using System.Text;

namespace Practica2
{
    class Ejercicio6
    {
        static void Main(string[] args)
        {
            DateTime hoy = DateTime.Now;
            
            Console.WriteLine(hoy.ToString("\\H\\o\\y \\e\\s "+ "dddd, dd \\d\\e MMMM \\d\\e yyyy \\y \\s\\o\\n \\l\\a\\s hh:mm tt"));
            Console.ReadKey();
        }
    }
}
