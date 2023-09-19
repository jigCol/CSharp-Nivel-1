/*3. Hacer un programa que solicite 20 edades y luego calcule el promedio de 
edad de aquellas personas mayores a 18 años.*/

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int edad, sumaEdad = 0, con = 0, promedio;
            Console.WriteLine("Se le pedira que ingrese 20 edades y se calculara el promedio de aquellas mayores a 18.");

            for(int x = 0; x < 20; x++){

                Console.Write($"Ingrese una edad({x+1}):");
                edad = int.Parse(Console.ReadLine());

                if(edad > 18){
                    sumaEdad += edad;
                    con++;
                }
            }

            promedio = sumaEdad / con;

            Console.WriteLine($"\nEl promedio es {promedio}.");
        }
    }
}
