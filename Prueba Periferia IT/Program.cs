using System;
using System.Runtime.CompilerServices;
using System.Threading;

namespace Prueba_Periferia_IT
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Prueba de algoritmos Periferia! \n\n Presione: \n 1. prueba 1 \n 2. prueba 2 \n 3. prueba 3 \n 0. Salir");
            int rpta = Int32.Parse(Console.ReadLine());
            Console.WriteLine("---------------------");
            switch (rpta)
            {
                case 1:
                    punto_A();
                    break;
                case 2:
                    punto_B();
                    break;
                case 3:
                    Console.WriteLine("Escogio 3");
                    break;
                default:
                    Console.WriteLine("No valido!");
                    break;
            }
        }

        private static void punto_A()
        {
            //a.Escriba un algoritmo que imprima los números del 1 al 100, pero con las siguientes consideraciones:
            //Si el número es divisible por 3, se debe imprimir “Bin”
            //Si el número es divisible por 5, se debe imprimir “Go”
            //Si se cumplen ambas condiciones(divisible por 3 y por 5), se debe imprimir
            //“Bingo!”

            int num = 1;
            while (num <= 100)
            {
                if (num % 3 == 0 && num % 5 == 0)
                {
                    Console.WriteLine($"Bingo #{num}");
                }
                else
                {
                    if (num % 3 == 0)
                        Console.WriteLine($"Bin #{num}");
                    if (num % 5 == 0)
                        Console.WriteLine($"Go #{num}");
                }

                num += 1;
            }
        }

        private static void punto_B()
        {
            //b. Escriba un algoritmo para calcular e imprimir los primeros 50 números primos

            int a = 0, num = 1;

            Console.WriteLine("Lista Numeros Primos");
            while (num <= 50)
            {
                for (int i = 1; i < (num + 1); i++)
                {
                    if (num % i == 0)
                    {
                        a++;
                    }
                }
                if (a == 2)
                    Console.WriteLine($"{num}");
                a = 0;
                num += 1;
            }
        }

    }
}
