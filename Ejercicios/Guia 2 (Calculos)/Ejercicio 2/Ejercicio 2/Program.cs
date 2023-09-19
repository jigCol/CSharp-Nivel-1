//2. Hacer un programa para solicitar por teclado un número y luego devolver su valor elevado al cubo.

using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
          int n1,cubo;
          Console.Write("Ingrese un numero y se elevara al cubo: ");
          n1=int.Parse(Console.ReadLine());

          cubo=n1*n1*n1;

          Console.WriteLine("El resultado es: "+cubo);
        }
    }
}
