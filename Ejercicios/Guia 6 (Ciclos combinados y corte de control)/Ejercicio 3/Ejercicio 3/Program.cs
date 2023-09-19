/*3. Hacer un programa para recibir listas de números positivos que están separadas entre sí por un cero.
 El fin de la carga se notifica con un número negativo. Luego mostrar cuántos números tiene cada lista.*/

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, lista = 0;
            Console.WriteLine("Se armaran listas de numeros positivos separadas por un 0.");
            Console.WriteLine("Ingrese un numero negativo para finalizar el programa.");


            Console.Write("\nIngrese un numero positivo:");
            n = int.Parse(Console.ReadLine());

            while(n >= 0){
                int con = 0;
                lista++;
                Console.WriteLine($"Lista {lista}.(Negativo para finalizar o 0 para cortar la lista)");

                while(n != 0){

                    con++;

                    Console.Write("Ingrese un numero positivo: ");
                    n = int.Parse(Console.ReadLine());

                }

                Console.WriteLine($"\nLa lista {lista}, tiene {con} numeros.\n");
                
                Console.Write("\nIngrese un numero positivo: ");
                n = int.Parse(Console.ReadLine());

            }
            
        }
    }
}
