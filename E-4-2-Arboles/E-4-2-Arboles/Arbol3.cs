using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2_Arboles
{
    class Arbol3
    {
        public void MetodoArbol3()
        {
            Arbol Llamada = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            Llamada.Insertar(10, 'I');
            Llamada.Insertar(3, 'B');
            Llamada.Insertar(2, 'A');
            Llamada.Insertar(4, 'C');
            Llamada.Insertar(15, 'D');
            Llamada.Insertar(12, 'E');
            Llamada.Insertar(11, 'F');
            Llamada.Insertar(13, 'G');
            Llamada.Insertar(14, 'H');
            Llamada.Insertar(20, 'I');
            Llamada.Insertar(30, 'J');
            //Impresion en preorden
            Console.WriteLine("Impresion preorden: ");
            Llamada.ImprimirPre();
            //Impresion en inorden
            Console.WriteLine("Impresion inorden: ");
            Llamada.ImprimirEntre();
            //Impresion en post-orden
            Console.WriteLine("Impresion postorden: ");
            Llamada.ImprimirPost();
            Console.WriteLine("Niveles: " + 4);
            //Ruta
            Rutas();
            Console.ReadKey();
        }
        public void Rutas()
        {
            Console.WriteLine("Ruta a C: \nI -> C");
            Console.WriteLine("Ruta a J: \nI -> D -> I -> J");
            Console.WriteLine("Ruta a H: \nI -> D -> E -> G -> H");
            Console.WriteLine("Mas larga: \nI -> D -> E -> G -> H");
        }
    }
}
