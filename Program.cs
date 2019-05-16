﻿using System;

namespace Fibo
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Podaj liczbę testów do wykonania: ");
            string input = "0";

            do
            {
                input = Console.ReadLine();
                if (int.TryParse(input, out int test) == false || int.Parse(input) < 3)
                    Console.WriteLine("Niepoprawna wartość!");
            } while (int.TryParse(input, out int result) == false || int.Parse(input) < 3);

            int[] fibonacci = new int[int.Parse(input)];
            fibonacci[0] = 0;
            fibonacci[1] = 1;

            for (int i = 2; i < fibonacci.Length; i++)
                fibonacci[i] = fibonacci[i - 2] + fibonacci[i - 1];

            for (int j = 0; j < fibonacci.Length; j++)
                Console.Write("{0} ", fibonacci[j]);

            Console.ReadKey();
        }
    }
}
