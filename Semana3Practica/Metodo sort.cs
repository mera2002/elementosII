using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3Practica
{
    class Metodo_sort
    {
        static void Main()
        {

         

            string[] persona = new string[4];
            persona[0] = "Tia";
            persona[1] = "Mamà";
            persona[2] = "primo";
            persona[3] = "sobrino";

            string[] nombres = new string[4];
            nombres[0] = "Ana";
            nombres[1] = "Rosa";
            nombres[2] = "Jefferson";
            nombres[3] = "Dylan";


            int[] Edad = new int[4];
            Edad[0] = 30;
            Edad[1] = 11;
            Edad[2] = 42;
            Edad[3] =  1;

           
            for (int i = 0; i < persona.Length; i++)
            {
       
                Console.WriteLine(" Persona {0}: {1} ", i, persona[i]); 


            }
            for (int i = 0; i < nombres.Length; i++)
            {
     
                Console.WriteLine(" Nombre {0}: {1} ", i, nombres[i]);  
            }

            Array.Sort(Edad); 
           

            for (int i = 0; i < Edad.Length; i++)
            {
       
                Console.WriteLine(" Edad {0}: {1} ", i, Edad[i]); 

            }

            Console.ReadKey();

        }
        
    }
}
