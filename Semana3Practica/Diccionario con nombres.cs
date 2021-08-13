using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana3Practica
{
    class Diccionario_con_nombres
    {
        static void Main()
        {
           
            //Diccionario con nombres de integrastes de familia y edad 

            //definir un diccionario
            Dictionary<string, float> Nombres = new Dictionary<string, float>();
            //agregar elementos al diccionario
            Nombres.Add("TIA: Ana", 30f);
            Nombres.Add("MAMA: Rosa", 42f);
            Nombres.Add("PRIMO: Jeffeson", 11f);
            Nombres.Add("SOBRINO: Dylan", 1f);

            //leer diccionario y mostrar datos
            foreach (KeyValuePair<string, float> Nom in Nombres)
            {
                Console.WriteLine("Key: {0}, Value: {1}", Nom.Key, Nom.Value);
            }


            //ordenar diccionario
            //definir diccionario como una lista
            var lista = Nombres.Keys.ToList();
            lista.Sort();
            Console.WriteLine("Diccionario ordenado");
            foreach (var orde in lista)
            {
                Console.WriteLine("Key: {0}, Value: {1}", orde, Nombres[orde]);
            }


            Console.ReadKey();
        }
    }
}