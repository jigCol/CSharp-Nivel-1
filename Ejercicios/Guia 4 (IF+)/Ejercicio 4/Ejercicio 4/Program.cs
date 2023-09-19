/*4. Hacer un programa para ingresar tres números y emitir un cartel aclaratorio si la suma de 
los dos primeros es mayor al producto del segundo con el tercero.*/

using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3;
            Console.WriteLine("Ingrese 3 numeros:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());

            if((n1+n2) > (n2*n3)){
                Console.WriteLine("\nSi, la suma de los dos primeros es mayor al producto del segundo con el tercero.\n");
            }else{
                Console.WriteLine("\nNo, la suma de los dos primeros es menor al producto del segundo con el tercero.\n");
            }
        }
    }
}
