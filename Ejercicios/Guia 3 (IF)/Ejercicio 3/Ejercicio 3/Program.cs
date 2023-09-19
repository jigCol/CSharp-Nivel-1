/*3. Una casa de video juegos otorga un descuento dependiendo del importe 
de la compra realizada según los siguientes valores:

Si el importe es menor a ARS 1000, no hay descuento.
Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%.
Si el importe es ARS 5000 o más, aplica un descuento del 18%.
Hacer un programa para ingresar un importe de venta y luego muestre por 
pantalla el importe final con el descuento que corresponda.*/


using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            float importe;
            Console.Write("Ingrese el importe de su compra: ");
            importe = float.Parse(Console.ReadLine());
            Console.WriteLine("Se realizaran descuentos si: "+"\n"+
            "-Si el importe es ARS 1000 o más pero menor a ARS 5000, aplica un descuento del 10%."+"\n"+
            "-Si el importe es ARS 5000 o más, aplica un descuento del 18%."+"\n"+
            "-Si es menor a ARS 1000, no habra descuento"+"\n");

            if(importe>=5000){
                Console.WriteLine("Aplica 18% descuento.");
                importe*=0.82f;
            }else if(importe<5000){
                if(importe<1000){
                    Console.WriteLine("No habra descuento.");
                }else{
                    Console.WriteLine("Aplica 10% descuento.");
                    importe*=0.90f;
                }
                
            }

            Console.WriteLine("\n"+"El importe final es de: "+importe+"."+"\n");
        }
    }
}
