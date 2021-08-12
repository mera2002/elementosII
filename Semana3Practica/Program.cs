using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3Practica
{
    class Program
    {
        static void Main(string[] args)
        {
            //loops
            loops(); //llamado al metodo loops()
            Console.ReadKey();
        }

        //while
        //evalua la condicion y ejecuta las intrucciones 
        //si la condicion es verdadera 

        public static void loops()
        {
            int[] nums = new int[3]; //crear un arreglo 

            //llenar arreglo 
            nums[0] = 4;
            nums[1] = 22;
            nums[2] = 8;

            //imprimir los numeros utilizando while 
            int i = 0, idw = 0;
            Console.WriteLine("IMPRIMIENDO CON WHILE");
            while (i < nums.Length)
            {
               
                Console.WriteLine("Indice {0}: {1}", i, nums[i]);
                i++;
            }
            //Imprimir con ciclo dowhile 
            //la condicion se evalua al final 
            Console.WriteLine("IMPRIMIENDO CON DOWHILE: ");
            do
            {
               
                Console.WriteLine("Indice {0}: {1}", idw, nums[idw]);
                idw++;

            } while (idw < nums.Length);

            //Imprimir con ciclo  for 
            //se comprueba la ondicion primero y luego se ejecuta si la condicion es verdadera 
            Console.WriteLine("IMPRIMIENDO CON CICLO FOR: ");
            for (int inc=0; inc < nums.Length; inc++)
            {
                Console.WriteLine("Indice {0}:  {1}", inc, nums[inc]);
               

            }
        }

    }
}
     
    
