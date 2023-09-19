/*4. Una casa de computación paga a sus empleados un sueldo fijo de ARS15000 
más una comisión del 5% sobre el total facturado por cada empleado.
 Hacer un programa para ingresar el total facturado por un empleado 
y que luego calcule y emita por pantalla el sueldo total a cobrar por el mismo.*/


using System;

namespace Ejercicio_4
{
    class Program
    {
        static void Main(string[] args)
        {
            float tf,tfc, sueldof=15000f,total;

        Console.Write("Ingrese su total facturado(Se le sumara una comision del 5%): ");
        tf=float.Parse(Console.ReadLine());

        tfc=tf*0.05f;

        Console.WriteLine("\n"+"Su comision es de "+tfc+".");
        Console.WriteLine("Su sueldo fijo es de "+sueldof+"ARS.");

        total=tfc+sueldof;

        Console.WriteLine("Su total es de "+total.ToString("0.00")+"ARS."+"\n");
        
      

           
        }
    }
}
