/*5. Hacer un programa para ingresar por teclado las tres notas de exámenes de un alumno 
y luego calcule y emita por pantalla el promedio final.*/

using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
           int nota1,nota2,nota3;
           float promedio;

           Console.WriteLine("\n"+"Se deberan ingresar las 3 notas de examenes de un alumno y se realizara el promedio.");
           Console.Write("Ingrese la primer nota: ");
           nota1=int.Parse(Console.ReadLine());
           Console.Write("Ingrese la segunda nota: ");
           nota2=int.Parse(Console.ReadLine());
           Console.Write("Ingrese la tercer nota: ");
           nota3=int.Parse(Console.ReadLine());

           promedio=(nota1+nota2+nota3)/3;

           Console.WriteLine("\n"+"El promedio es de: "+promedio+"."+"\n");
        }
    }
}
