/*3. Hacer un programa que permita ingresar los kilómetros existentes entre dos ciudades y 
la velocidad promedio de un vehículo. 
Calcular y emitir por pantalla el tiempo aproximado que demandará 
llegar de un punto a otro teniendo en cuenta los datos ingresados.*/

using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {int km,vp,tiempo;

          Console.Write("Ingrese los KM entre 2 ciudades: ");
          km=int.Parse(Console.ReadLine());
          Console.Write("Ingrese la velocidad promedio de un vehiculo: ");
          vp=int.Parse(Console.ReadLine());

          tiempo=km/vp;
          Console.Write("\n");

          Console.WriteLine("Recorrer "+km+"km con una velocidad promedio de "+vp+" se tardaran "+tiempo+" horas."+"\n");
          



        }
    }
}
