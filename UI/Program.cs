using System;
using Teoria3.Core;

namespace Teoria3
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            var d = new Directivo("Pepito");
            var o = new Obrero("Javier");
            
            Console.WriteLine(o);
            Console.WriteLine("Nómina: " + o.calculaNomina(10));
            
            Console.WriteLine(d);
            Console.WriteLine("Nómina: " + d.calculaNomina(10));
            
            
        }
    }
}