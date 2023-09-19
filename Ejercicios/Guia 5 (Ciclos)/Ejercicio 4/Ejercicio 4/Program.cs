/*4. Hacer un programa que solicite UN número y luego calcule y emita un 
cartel aclaratorio si el mismo es primo o no es primo.  
Nota: un numero es primo cuando es divisible únicamente por 1 y por sí mismo.*/

using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n;
            Console.WriteLine("Ingrese un numero y se mostrara si es primo.");
            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            int cont = 0;

            for(int x = 1; x <= n; x++){


                if(n%x == 0){
                    cont++;
                }
            }

            if(cont == 2){
                Console.WriteLine("\nEl numero es primo.\n");
            }else{
                Console.WriteLine("\nEl numero no es primo.\n");
            }
        }
    }
}
