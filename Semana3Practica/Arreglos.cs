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
            int mayor = 0, j = 0;
            int suma = 0;

            string[] nombres = new string[3];
            for (int i = 0; i < nombres.Length; i++)

            {
                Console.WriteLine("Ingrese el nombre del estudiante {0}:  ", i);
                nombres[i] = Console.ReadLine();

            }


            //calcular la nota promedio de N notas 
            int[] notas = new int[3];

            //capturar las notas 
            for (int i = 0; i < notas.Length; i++)
            {
                //solicitar las notas al usuario 
                Console.Write("Ingrese la nota {0}:  ", i);
                notas[i] = Convert.ToInt32(Console.ReadLine());
            }

            //recorrer el arreglo de notas 

            Console.WriteLine("Array desordenado"); 
            for (int i = 0; i < nombres.Length; i++)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" Nombre del estudiante {0}: {1} ", i, nombres[i]); //Imprime los valores 


            }

            Array.Sort(notas); //el metodo sort de la clase Array permite ordenar los elemetos del arreglo 
           // Array.Reverse(notas);

            //ordenar el arreglo 


            for (int i = 0; i < notas.Length; i++)
            {
                Console.WriteLine("---------------------------------------------");
                Console.WriteLine(" Nota del estudiante {0}: {1} ", i, notas[i]); //Imprime los valores 

            }

            for (int i = 0; i < notas.Length; i++)

                suma = suma + notas[i]; 
                promedio = suma / notas.Length;
            {

                Console.WriteLine("---------------------------------------------");
                Console.WriteLine("El promedio de notas es : " + promedio);
                    
            }

            while (j < 3)
         

            {
                if (notas[j] > mayor)
                    mayor = notas[j];
                j++; 
                    

                }
            Console.WriteLine("La nota mayor es: {0}", mayor);
            Console.ReadKey();
        }
    }
        

    
}
