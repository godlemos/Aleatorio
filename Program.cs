using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aleatorio
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Ejercicio 1: Adivinar un número aleatorio entre 1 y 100
            Random rand = new Random();
            int numeroAleatorio = rand.Next(1, 101); // Genera un número entre 1 y 100
            int intento;
            do
            {
                Console.Write("Adivina el número (entre 1 y 100): ");
                intento = int.Parse(Console.ReadLine());

                if (intento < numeroAleatorio)
                {
                    Console.WriteLine("El número es mayor.");
                }
                else if (intento > numeroAleatorio)
                {
                    Console.WriteLine("El número es menor.");
                }
                else
                {
                    Console.WriteLine("¡Adivinaste el número!");
                }
            } while (intento != numeroAleatorio);

            Console.WriteLine("¡Felicidades! Has adivinado el número correctamente.");
        }
    }
}
