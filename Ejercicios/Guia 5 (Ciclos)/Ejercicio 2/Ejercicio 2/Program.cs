/*2. Hacer un programa que solicite el ingreso de 10 números y que muestre el 
mayor de ellos por pantalla. Solo se debe emitir UN valor por pantalla.*/

using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0;
            Console.WriteLine("Se le pedira ingresar 10 numeros y se mostrara el mayor de ellos.");
            for(int x = 0; x < 10; x++){

                Console.Write($"Ingrese un numero({x+1}):");
                n = int.Parse(Console.ReadLine());

                if(n > max){
                    max = n;
                }

            }

            Console.WriteLine($"\nEl mayor numero ingresado es el {max}.");
            
        }
    }
}
