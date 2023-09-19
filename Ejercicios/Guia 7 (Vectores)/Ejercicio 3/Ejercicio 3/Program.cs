/*3. Hacer un programa que solicite una cadena de caracteres y dos caracteres sueltos (tres ingresos). 
El programa deberá generar una cadena donde todas las ocurrencias del primer carácter dado hayan sido
 reemplazadas por el segundo. Mostrar el resultado en pantalla. Ejemplo:

CADENA FUENTE: “La mar estaba serena"
CARÁCTER 1: ‘a’ CARÁCTER 2: ‘i’
CADENA RESULTADO: “Li mir estibi sereni"*/


using System;

namespace Ejercicio_3
{
    class Program
    {
        static void Main(string[] args)
        {
            string cadena;
            char a, b;
            Console.WriteLine("Ingrese un texto: ");
            cadena = Console.ReadLine();
            Console.WriteLine("Ingrese un caracter: ");
            a = char.Parse(Console.ReadLine());
            Console.WriteLine("Ingrese otro caracter: ");
            b = char.Parse(Console.ReadLine());

            Console.WriteLine("\nDonde se encuentre el caracter a, en el texto, se reemplazara por el caracter b.");

            string nuevaCadena = "";

            for(int x = 0; x < cadena.Length; x++){
                
                if(cadena[x] == a){
                    nuevaCadena += b;
                }else{
                    nuevaCadena += cadena[x];
                }
            }

            Console.WriteLine($"\nResultado: {nuevaCadena}.\n");
        }
    }
}
