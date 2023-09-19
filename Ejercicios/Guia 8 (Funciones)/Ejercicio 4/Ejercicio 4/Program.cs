/*4. Hacer una función de tipo void (porque no va a devolver nada)
 llamada “positivoNegativoCero” que reciba un número por valor y una variable por referencia. 
Que analice el número y escriba variable recibida por referencia con:

a. 1 si el número es positivo.
b. -1 si el número es negativo.
c. 0 si el número es cero.*/

using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, x = 0;
            Console.WriteLine("Ingrese un numero y se determinara si es negativo, positivo o cero.");
            Console.Write("Ingrese un numero: ");
            n = int.Parse(Console.ReadLine());

            positivoNegativoCero(n,ref x);
        }

        static void positivoNegativoCero(int n, ref int x){

            if(n < 0){
                x = -1;
                Console.WriteLine("El numero es negativo.\n");
            }else if(n > 0){
                x = 1;
                Console.WriteLine("El numero es positivo.\n");
            }else{
                x = 0;
                Console.WriteLine("El numero es cero.\n");
            }

        }
    }
}
