//5. Hacer un programa para ingresar cuatro números y luego mostrar por pantalla cuáles son mayores a 100.

using System;

namespace Ejercicio_5
{
    class Program
    {
        static void Main(string[] args)
        {
            int n1,n2,n3,n4;
            Console.WriteLine("Se ingresaran numeros y se mostraran cuales son mayores a 100.");
            Console.WriteLine("Ingrese 4 numeros: ");
            n1 =int.Parse(Console.ReadLine()); 
            n2 =int.Parse(Console.ReadLine()); 
            n3 =int.Parse(Console.ReadLine()); 
            n4 =int.Parse(Console.ReadLine()); 

            if(n1>100 || n2>100 || n3>100 || n4>100){
                Console.Write("Los numeros mayores a 100 son: ");
                if(n1>100){
                    Console.Write(n1+" ");
                }
                if(n2>100){
                    Console.Write(n2+" ");
                }
                if(n3>100){
                    Console.Write(n3+" ");
                }
                if(n4>100){
                    Console.Write(n4+" ");
                }
            }else{
                Console.WriteLine("No hay numeros mayores a 100."+"\n");
            }

        }
    }
}
