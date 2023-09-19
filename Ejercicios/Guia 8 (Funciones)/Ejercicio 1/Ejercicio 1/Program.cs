/*1. Hacer una función llamada “producto” que reciba dos números enteros y que devuelva el producto de ambos.
 Luego hacer un programa que pida el precio de un artículo y la cantidad vendida y 
muestre por pantalla el monto total a pagar. Usar la función.*/

using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1, n2;
            Console.WriteLine("Ingresa dos numeros y se devolvera el producto.");
            Console.Write("Ingrese el precio: ");
            n1 = int.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad: ");
            n2 = int.Parse(Console.ReadLine());

            Console.WriteLine("\nMonto total: "+Producto(n1,n2)+"\n");
        }

         static int Producto(int n1, int n2){
            int r;
         return r = n1*n2;
             }

    }
    
}
