﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Condicionales
{
    class Program
    {
        static void Main(string[] args)
        {
            int valor1 = 0, valor2 = 0;
            string cadena;

            Console.WriteLine("Dame el primer numero");
            cadena = Console.ReadLine();
            valor1 = Convert.ToInt32(cadena);

            Console.WriteLine("Dame el segundo numero");
            cadena = Console.ReadLine();
            valor2 = Convert.ToInt32(cadena);

            if (valor1 > valor2)
                Console.WriteLine("El valor  1 es mayor al valor 2");
            else
                Console.WriteLine("El valor 2 es mayor al valor 1");

            Console.ReadKey();

        }
    }
}
