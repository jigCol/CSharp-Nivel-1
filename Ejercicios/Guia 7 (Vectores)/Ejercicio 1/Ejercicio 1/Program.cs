/*1. Hacer un programa que solicite 10 números enteros y los guarde en un vector. 
Luego recorrer los elementos y determinar e informar cuál es el valor máximo y su posición dentro del vector.*/


using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int [] numeros = new int[10];
            int n;

            Console.WriteLine("Se guardaran 10 numeros en un vector.");

            for(int x = 0; x < 10; x++){

                Console.Write($"({x+1})Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());

                numeros[x] = n;

            }

            int mayor = numeros[0], pos = 0;

            for(int x = 0; x < 10; x++){

                if(numeros[x] > mayor){

                    mayor = numeros[x];
                    pos = x+1;
                }

            }

            Console.WriteLine($"\nEl mayor numero es el {mayor} en la posicion {pos}\n");
        }
    }
}
