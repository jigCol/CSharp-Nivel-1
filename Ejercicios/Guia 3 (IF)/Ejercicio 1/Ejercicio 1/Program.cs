/*1. Hacer un programa para ingresar un número y luego se emita por pantalla un 
cartel aclaratorio si “Es mayor a 10” o “No es mayor a 10”.*/

using System;

namespace Ejercicio_1
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1;
            Console.Write("\n"+"Ingrese un numero: ");
            n1 = int.Parse(Console.ReadLine());

            if(n1>10){
                Console.WriteLine("\n"+"El numero es mayor a 10."+"\n");
            }else{
                Console.WriteLine("\n"+"El numero no es mayor a 10"+"\n");
            }
        }
    }
}
