/*1. Hacer un programa que solicite el ingreso de dos números y luego calcular:

La resta si el primero es mayor que el segundo.
La suma si son iguales.
El producto si el primero es menor.
Se deberá emitir un cartel por pantalla con el resultado correspondiente.*/

using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2;
            Console.WriteLine("Ingrese 2 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());

            if(n1 > n2)
                Console.WriteLine("\n"+(n1-n2));
            else if(n1 == n2)
                Console.WriteLine("\n"+(n1+n2));
            else
                Console.WriteLine("\n"+(n1*n2));
            

        }
    }
}
