using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio1
{
    class Program
    {
        static void Main(string[] args)
        {

            // 1) Crea un array de 10 posiciones de números con valores pedidos por teclado. Muestra por consola el indice y el valor al que corresponde.

            
            int[] array = new int[10];

            for (int i = 0; i < array.Length; i++)
            {
                Console.WriteLine("Ingrese el valor en la posición " + i);
                string p = Console.ReadLine();
                int pParseado = int.Parse(p);

                array[i] = pParseado;
                                               
            }
            for (int i = 0; i < array.Length; i++)
            {
             Console.WriteLine("array [" + i + "] " + "= "+ array[i]);
                                                 
            }
            Console.ReadKey();

    
            
        }
    }
}
