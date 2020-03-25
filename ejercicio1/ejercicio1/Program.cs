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




            Dictionary<string, int> value = new Dictionary<string, int>();
            //Rellenar diccionario con add 

            value.Add("Juan", 55423412);
            value.Add("Ernesto", 56985623);
            value.Add("Mariana", 54787451);

            // buscar palabra
            if (value.ContainsKey("Juan"))
                Console.WriteLine(value["Juan"]);

            else
                Console.WriteLine("No se encuentara");





            // recorrer diccionario

            foreach (KeyValuePair<string, int> datos in value)
            {
                

                 Console.WriteLine("Nombre: " + datos.Key + " " + "valor " + datos.Value);














                


            }

            Console.ReadLine();

        }

        
    }

    
}


