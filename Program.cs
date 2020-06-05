using System;

namespace AulaPOOOverload
{
    class Program
    {
        static void Main(string[] args)
        {
            Calculos calc = new Calculos();
            Console.WriteLine(calc.Calcular());
            Console.WriteLine(calc.Calcular(10));
            Console.WriteLine(calc.Calcular(20, 2));
            Console.WriteLine(calc.Calcular("5", "10"));
        }
    }
}
