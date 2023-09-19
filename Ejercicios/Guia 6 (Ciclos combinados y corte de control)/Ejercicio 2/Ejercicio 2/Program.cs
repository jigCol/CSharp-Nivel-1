/*2. Se dispone de una lista de 5 listas de números enteros separados entre ellos por ceros.
 Se pide determinar e informar:

El número de grupo con mayor porcentaje de números impares respecto al total de números que forman el grupo.
Informar cuántos grupos están formados por todos números ordenados de mayor a menor.*/

using System;

namespace Ejercicio_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int n, porcentaje, porcentajeMayor = 0, mayorGrupo = 0, gruposOrdenados = 0;
            bool b = true;
            for(int x = 0; x < 5; x++){
                
                int conNum = 0, conImpares = 0, n1 = 0;
                bool bOrdenado = true, bPrimero = true;

                Console.Write($"\nIngrese un numero-LISTA {x+1}-(0 para cambiar de lista): ");
                n = int.Parse(Console.ReadLine());

                while(n != 0){

                    conNum++;

                    if(n % 2 != 0){
                        conImpares++;
                    }

                    if(bPrimero){
                        n1 = n;
                        bPrimero = false;
                    }else if(n1 > n){
                        n1 = n;
                    }else{
                        bOrdenado = false;
                    }

                    Console.Write($"Ingrese un numero-LISTA {x+1}-(0 para cambiar de lista): ");
                    n = int.Parse(Console.ReadLine());

                }

                if(bOrdenado){
                    gruposOrdenados++;
                }

                porcentaje = (conImpares * 100)/conNum;

                if(b){
                    mayorGrupo = (x+1);
                    porcentajeMayor = porcentaje;
                    b = false;
                }else if(porcentaje > porcentajeMayor){
                    porcentajeMayor = porcentaje;
                    mayorGrupo = (x+1);
                }
            }
            
            
            Console.WriteLine($"\nEl numero de grupo con mayor porcentaje de numeros impares es el {mayorGrupo}, con un porcentaje de {porcentajeMayor}%.");
            Console.WriteLine($"Grupos ordenados de mayor a menor = {gruposOrdenados}.\n");
        }
    }
}
