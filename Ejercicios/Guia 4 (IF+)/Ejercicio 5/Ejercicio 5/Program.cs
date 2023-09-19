/*5. Hacer un programa para ingresar 4 números. Luego analizar e informar por pantalla si los mismos 
se encuentran ordenados de forma decreciente .*/

using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;
            Console.WriteLine("Ingrese 4 numeros y se informara si estan ordenados de forma decreciente:");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            if(n1 > n2 && n2 > n3 && n3 > n4){
                Console.WriteLine("\nEstan ordenados de forma decreciente.\n");
            }else{
                Console.WriteLine("\nNo estan ordenados de forma decreciente.\n");
            }
        }
    }
}
