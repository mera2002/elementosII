using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3Practica
{
    class Arreglos
    {
        static void Main()
        {
            Double promedio;
           
            int suma = 0;
            
           
        //calcular la nota promedio de N notas 
        int[] notas = new int[10];

            //capturar las notas 
            for (int i = 0; i < notas.Length; i++)
            {
                //solicitar las notas al usuario 
                Console.Write("Escriba la nota {0}:", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            //recorrer el arreglo de notas 
            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("Nota {0}: {1}", i, notas[i]); //Imprime los valores 

               


            }
            for (int i = 0; i < notas.Length; i++)

                suma = suma + notas[i]; 
                promedio = suma / notas.Length;
            {

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("La suma de las notas es: "+suma);
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("El promedio de notas es notas es: " + promedio);
            }

           
            
            Console.ReadKey();
        }
        

    }
}
