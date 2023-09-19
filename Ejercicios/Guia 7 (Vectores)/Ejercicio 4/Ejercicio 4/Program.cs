/*4. Una empresa comercializa 15 tipos de artículos y por cada venta realizada genera un registro con 
los siguientes datos:

- Número de Artículo (1 a 15)
- Cantidad Vendida 

Puede haber varios registros para el mismo artículo y el último se indica con número de artículo igual a 0.
Se pide determinar e informar:
a) El número de artículo que más se vendió en total.
b) Los números de artículos que no registraron ventas.
c) Cuantas unidades se vendieron del número de artículo 10.*/


using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] vNumArt = new int[15];
            int[] vCantV  = new int[15];

            for(int x = 0; x < 15; x++){

                vNumArt[x] = x+1;
                vCantV[x] = 0;
            }

            int numArt, cantV;

            Console.WriteLine("Ingrese el numero de articulo: ");
            numArt = int.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese la cantidad vendida: ");
            cantV = int.Parse(Console.ReadLine());

            int i = 0;

            while(numArt != 0){

                for(int x = 0; x < 15; x++){

                    if(vNumArt[x] == numArt){
                        i = x;
                    }
                }

                vCantV[i] += cantV;

                Console.WriteLine("\nIngrese el numero de articulo: ");
                numArt = int.Parse(Console.ReadLine());
                Console.WriteLine("Ingrese la cantidad vendida: ");
                cantV = int.Parse(Console.ReadLine());

            }

            int masVendido = vCantV[0], mayorNumArt = vNumArt[0];

            Console.Write("Los numeros de articulos que no registraron ventas son: ");

            for(int x = 0; x < 15; x++){

                if(vCantV[x] > masVendido){
                    masVendido = vCantV[x];
                    mayorNumArt = vNumArt[x];
                }

                if(vCantV[x] == 0){
                    Console.Write(" "+vNumArt[x]+" ");
                }
            }
            
            Console.WriteLine($"\nEl numero de articulo que mas se vendio en total es el {mayorNumArt}.");
            Console.WriteLine($"Para el numero de art.10, se vendieron {vCantV[9]} unidades.\n");
        }
    }
}
