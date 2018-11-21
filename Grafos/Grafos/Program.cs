using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Program
    {
        static void Main(string[] args)
        {
            Grafo llamar = new Grafo(); //Hace la instanciación del objeto
            Console.WriteLine("Las rutas son:\n");
            for (int contador = 1; contador < 7; contador++)
            {
                Console.Write("\t");  //Agrega los tab a la consola
                llamar.Rutas(contador);//Llama al metodo para desplegar las rutas
            }
            Console.ReadKey();
        }
    }
}
