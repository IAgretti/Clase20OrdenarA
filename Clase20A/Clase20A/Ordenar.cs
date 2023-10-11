using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Clase20A
{
    internal class Ordenar
    {
        int[] datos = { 5, 3, 14, 20, 8, 9, 1 };
        int datoTemporal;
        public void Burbuja()
        {
            
            Console.WriteLine("Ordenando mediante burbuja...");
            for (int i = 0; i < (datos.Length) - 1; i++)
            {
                foreach (int dato in datos)
                {
                    Console.Write("{0} ", dato);
                }
                Console.WriteLine();

                for (int j = i + 1; j < datos.Length; j++)
                {
                    if (datos[i] > datos[j])
                    {
                        datoTemporal = datos[i];
                        datos[i] = datos[j];
                        datos[j] = datoTemporal;
                    }
                }
            }
            Console.Write("Ordenado: ");
            foreach (int dato in datos)
                Console.Write("{0} ", dato);
            Console.WriteLine();
        }
       public void Seleccion()
        {
           
            Console.WriteLine("Ordenando mediante selección directa...");
            for (int i=0; i < (datos.Length) - 1; i++)
            {
                foreach (int d in datos)
                    Console.Write("{0} ", d);
                Console.WriteLine();

                int menor = i;
                for (int j = i + 1; j < datos.Length; j++)
                    if (datos[j] < datos[menor])
                        menor = j;
                if (i != menor)
                {
                    datoTemporal = datos[i];
                    datos[i] = datos[menor];
                    datos[menor] = datoTemporal;
                }
            }
            Console.Write("Ordenado: ");
            foreach (int d in datos)
                Console.Write("{0} ", d);
            Console.WriteLine();
        }
        public void Insercion()
        {
            int j;
            Console.WriteLine("Ordenando mediante Inserción directa...");
            for (int i = 1; i < datos.Length; i++)
            {
                foreach (int d in datos)
                    Console.Write("{0} ", d);
                Console.WriteLine();
                j = i;

                while ((j > 0) && (datos[j - 1] > datos[j]))
                {
                    datoTemporal = datos[j];
                    datos[j] = datos[j - 1];
                    datos[j - 1] = datoTemporal;
                    j--;
                }
            }
                Console.Write("Ordenado: ");
                foreach (int d in datos)
                    Console.Write("{0} ", d);
                Console.WriteLine();
            
        }
    }
    
}
