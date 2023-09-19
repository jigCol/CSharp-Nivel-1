/*5. Hacer un programa que solicite 20 números y luego emitir por pantalla el máximo 
de los números pares y el mínimo de los números impares.*/

using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, max = 0, min = 0;
            bool b = true;
            Console.WriteLine("Se solicitaran 20 numeros.");

            for(int x = 0; x < 20; x++){

                Console.Write($"Ingrese un numero({x+1}):");
                n = int.Parse(Console.ReadLine());


                if(n%2 == 0){
                    if(n > max){
                        max = n;
                    }
                }else{
                    if(b){
                        min = n;
                        b = false;
                    }else if(n < min){
                        min = n;
                    }
                }

            }

            Console.WriteLine($"\nEl maximo de los pares es {max} y el minimo de los impares es {min}.\n");

        }
    }
}
