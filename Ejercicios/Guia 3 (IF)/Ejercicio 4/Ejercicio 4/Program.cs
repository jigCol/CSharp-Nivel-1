//4. Hacer un programa para ingresar cuatro números distintos y luego mostrar por pantalla el menor de ellos.

using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;
            Console.WriteLine("Se determinara el menor de 4 numeros.");
            Console.Write("Ingrese 4 numeros: ");
            n1 = int.Parse(Console.ReadLine());
            n2 = int.Parse(Console.ReadLine());
            n3 = int.Parse(Console.ReadLine());
            n4 = int.Parse(Console.ReadLine());

            int menor=n1;

            if(n2<menor){
                menor=n2;
            }
            if(n3<menor){
                menor=n3;
            }
            if(n4<menor){
                menor=n4;
            }

            Console.WriteLine("\n"+"El menor numero ingresado es el: "+menor+"."+"\n");
            
        }
    }
}
