using System;

namespace Calculadora
{
    class Program
    {
        static void Main(string[] args)
        {   //0-Declarar variables y tipos de dato: int-float-char-bool-string
            int n1, n2, resultado;

            //1-Pedir Valores
            Console.WriteLine("Ingrese un numero");
            n1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro numero");
            n2 = int.Parse(Console.ReadLine());

            //2-Procesar
            resultado = n1 + n2;

            //3-Mostrar Resultado
            Console.WriteLine("El resultado es: " + resultado);
            
            
        }
    }
}
