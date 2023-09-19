//1. Hacer un programa para solicitar dos números y luego calcule y emita la suma en pantalla.


using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
          int n1,n2,res;

          Console.Write("Ingrese un numero: ");
          n1=int.Parse(Console.ReadLine());
          Console.Write("Ingrese otro numero: ");
          n2=int.Parse(Console.ReadLine());
            
          res=n1+n2;
          Console.Write("\n");

          Console.Write("El resultado es: "+res);


        }
    }
}
