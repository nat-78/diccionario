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




            Dictionary<string, int> values = new Dictionary<string, int>();
            //Rellenar diccionario con add 

            values.Add("Juan", 55423412);
            values.Add("Ernesto", 56985623);
            values.Add("Mariana", 54787451);

            // buscar palabra con containskey
            if (values.ContainsKey("Juan"))
                Console.WriteLine(values["Juan"]);

            else
                Console.WriteLine("No se encuentara");

            // buscar palabra con trygetvalue
            int ap = 0;
            if (values.TryGetValue("Pedro", out ap))
            {
                Console.WriteLine(values["Pedro"]);
            }
            else
            {
                Console.WriteLine("No se encuentra Pedro");
            }


            // recorrer diccionario

            foreach (KeyValuePair<string, int> datos in values)
            {
                

                 Console.WriteLine("Nombre: " + datos.Key + " " + "valor " + datos.Value);














                


            }

            Console.ReadLine();

        }

        
    }

    
}


