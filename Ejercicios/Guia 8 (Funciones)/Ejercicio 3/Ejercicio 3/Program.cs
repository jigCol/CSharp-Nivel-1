/*3. Hacer una función llamada “primo” que reciba un número entero y 
devuelva 1 si el número es primo o cero si no lo es. 
Hacer un programa para ingresar números. 
El lote corta cuando se ingresa un número cero.
 Informar el promedio teniendo en cuenta sólo los números primos.*/

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, acu = 0, con = 0;
            Console.WriteLine("Ingrese numeros y se determinara si son primos.");
            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());
            
            while(n != 0){

                Primo(n);
                if(Primo(n) == 1){
                    Console.WriteLine("Es primo.");
                    con++;
                    acu += n;
                }else{
                    Console.WriteLine("No es primo.");
                }

                Console.Write("Ingrese un numero: ");
                n = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nEl promedio de numeros primos es "+Promedio(con,acu)+".\n");
            
            
        }

        static int Primo(int n){

            int con = 0;

            for(int x = 1; x <= n; x++){

                if(n % x == 0){
                    con++;
                }
            }

            if(con == 2){
                return 1;
            }else{
                return 0;
            }

        }

        static int Promedio(int con, int acu){
            int r = 0;

            return r = acu/ con;
        }
    }
}
