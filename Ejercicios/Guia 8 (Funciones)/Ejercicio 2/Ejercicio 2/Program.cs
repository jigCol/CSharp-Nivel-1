/*2. Hacer una función llamada “par” que reciba un número entero y devuelva 1 si es par o cero si no lo es.
 Hacer un programa para ingresar 20 números y mostrar por pantalla cuántos son pares.*/


using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, r, con = 0;

            for(int x = 0; x < 20; x++){

                Console.Write("Ingrese un numero y se determinara si es par: ");
                n = int.Parse(Console.ReadLine());

                r = Par(n);

                if(r == 1){
                    Console.WriteLine("\nEl numero es par.\n");
                    con++;
                }else{
                    Console.WriteLine("\nEl numero no es par.\n");
                }

            }

            Console.WriteLine($"\nEn total hay {con} numeros pares.\n");


        }

        static int Par(int n){

            int r = 0;
            if(n % 2 == 0){
                r = 1;
            }else{
                r = 0;
            }

            return r;
        }

        
    }
}
