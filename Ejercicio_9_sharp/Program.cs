using System;

namespace Ejercicio_9_sharp
{
    class Program
    {
        static void Main(string[] args)
        {
            int operacion1 = -5 + 8 * 6;
            int operacion2 = (55 + 9) % 9;
            decimal operacion3 = 20m + -3m * 5m / 8m;
            decimal operacion4 = 5m + 15m / 3m * 2m - 8m % 3m;

            Console.WriteLine("El resultado de la primera operación es: " + operacion1);
            Console.WriteLine("El resultado de la segunda operación es: " + operacion2);
            Console.WriteLine("El resultado de la tercera operación es: " + operacion3);
            Console.WriteLine("El resultado de la cuarta operación es: " + operacion4);
        }
    }
}
