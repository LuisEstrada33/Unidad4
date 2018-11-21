using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Grafos
{
    class Grafo
    {

        public void Rutas(int ruta) //Método que recibe el parametro ruta para elegir cual desplegar
        {
            switch (ruta) //Depende de 'ruta' se despliega la misma
            {
                case 1:
                    Console.WriteLine("A -> B -> C -> D -> E -> F -> G");
                    break;
                case 2:
                    Console.WriteLine("A -> B -> G -> F -> E -> D -> C");
                    break;
                case 3:
                    Console.WriteLine("A -> B -> C -> G -> F -> D -> E");
                    break;                                                      //Rutas disponibles
                case 4:
                    Console.WriteLine("A -> B -> G -> C -> D -> E -> F");
                    break;
                case 5:
                    Console.WriteLine("A -> B -> C -> G -> F -> E -> D");
                    break;
                case 6:
                    Console.WriteLine("A -> B -> G -> C -> D -> F -> E");
                    break;
            }
        }
    }
}
