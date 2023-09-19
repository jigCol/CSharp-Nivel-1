/*1. Hacer un programa para ingresar 10 números. 
El mismo debe analizar y mostrar por pantalla cuántos de esos números son primos.*/

using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, con = 0;
            Console.WriteLine("Se le solicitara ingresar 10 numeros y se mostraran cuantos son primos.");
            
            for(int x = 0; x < 10; x++){

            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            int conp = 0;

            for(int y = 1; y <= n; y++){

                if(n % y == 0){
                    conp++;
                }
            }

            if(conp == 2){
                con++;
            }
         

            }

            Console.WriteLine($"\nHay {con} numeros primos.\n");
            
        }
    }
}
