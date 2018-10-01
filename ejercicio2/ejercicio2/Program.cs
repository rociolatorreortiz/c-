using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ejercicio2
{
    class Program
    {
        static void Main(string[] args)
        {
            // 2) Crea un array de números donde le indicamos por teclado el tamaño del array, rellenaremos el array con 
            //números aleatorios entre 0 y 9, al final muestra por pantalla el valor de cada posición y la suma de todos los valores

            
            int suma;
            Console.WriteLine("Ingrese el tamaño del arreglo");
            string t = Console.ReadLine();
            int tParseado = int.Parse(t);

            Random rnd = new Random();//función aleatorio

            int[] numeros = new int[tParseado];

            Console.WriteLine(tParseado+" números aleatorio entre 0 y 9" + "\n");

            for (int i = 0; i < tParseado; i++)
            {
               
                
                numeros[i] = rnd.Next(0,9);//asigna numero aleatorio
               
            }

            for (int i = 0; i < numeros.Length; i++)
            {
                Console.WriteLine("numeros [" + i + "] " + "= " + numeros[i]);//muestra numero asignado a arreglo
                Console.ReadKey();
            }
            suma = numeros.Sum();//hace suma
            Console.WriteLine("\n" +"La sumatoria es "+ suma);//muestra suma
            Console.ReadKey();





        }
    }
}
