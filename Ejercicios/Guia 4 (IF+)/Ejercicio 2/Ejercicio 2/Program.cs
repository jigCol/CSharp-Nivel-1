/*2. Un importante negocio de desinfectante líquido realiza descuentos dependiendo de 
la cantidad de litros vendidos según la siguiente escala:

Si vende menos de 100 litros, no hay descuento.
Si vende entre 101 y 300 litros, el descuento es del 10%.
Si vende entre 301 y 500 litros, el descuento es del 15%.
Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.
Hacer un programa que solicite el ingreso del importe total de la venta y 
la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado..*/

using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe,cLitros;
            Console.Write("Ingrese el importe total: ");
            importe = float.Parse(Console.ReadLine());
            Console.Write("Ingrese la cantidad de litros: ");
            cLitros = float.Parse(Console.ReadLine());

            if(cLitros < 100){
                Console.WriteLine("No se realizara descuento.");
            }else if(cLitros <= 300){
                Console.WriteLine("Se realizara un descuento del 10%");
                importe = importe*0.90f;
            }else if(cLitros <=500){
                Console.WriteLine("Se realizara un descuento del 15%");
                importe = importe*0.85f;
            }else{
                Console.WriteLine("Se realizara un descuento del 25%");
                importe = importe*0.75f;
            }

            Console.WriteLine($"\nSu importe total es de {importe}.\n");

        }
    }
}
