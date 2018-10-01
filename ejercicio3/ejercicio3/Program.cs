using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio3
{
    class Program
    {
        static void Main(string[] args)
        {


            // 3) Programa c# que lea 10 números enteros por teclado y los guarde en un array. Calcula y muestra 
            //la media de los números que estén en las posiciones pares del array.

            int suma = 0, c = 0;
            int[] array = new int[10];
            

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingrese el valor en la posición " + i);
                string p = Console.ReadLine();
                int pParseado = int.Parse(p);

                array[i] = pParseado;

                if (i % 2 == 0 && i!=0)
                {
                    
                    c =c+1;
                }

            }

            Console.WriteLine("La posición par y valores del arreglo son= " + "\n");

            for (int i = 2; i < array.Length; i = i + 2)
            
            {
                Console.WriteLine("array[" + i + "] " + "= " + array[i]);
                suma = suma + array[i];
                

            }
            
            decimal resultado = suma/c;
            Console.WriteLine("\n"+"La media del arreglo es= " + resultado);
            Console.ReadKey();
        }
    }
}
