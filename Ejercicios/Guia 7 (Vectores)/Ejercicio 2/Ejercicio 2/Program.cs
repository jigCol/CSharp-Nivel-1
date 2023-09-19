/*2. Hacer un programa que solicite 10  números enteros y los guarde en un vector. 
Luego recorrer ese vector para calcular el promedio. Mostrar por pantalla los valores que 
son mayores al promedio.*/

using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numeros = new int [10];
            int n;

            for(int x = 0; x < 10; x++){

                Console.Write($"({x+1})Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                numeros[x] = n;
            }

            int acu = 0, promedio, con = 10;

            for(int x = 0; x < 10; x++){

                acu += numeros[x];
            }

            promedio = acu / con;

            Console.Write("Los numeros: ");
            for(int x = 0; x < 10; x++){

                if(numeros[x] > promedio){
                    Console.Write($"{numeros[x]} ");
                }
            }

            Console.WriteLine("\nSon mayores al promedio.\n");
        }
    }
}
