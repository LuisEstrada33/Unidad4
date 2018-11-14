using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2_Arboles
{
    class Arbol2
    {
        public void MetodoArbol2()
        {
            Arbol Llamada = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            Llamada.Insertar(30, 'C');
            Llamada.Insertar(3, 'D');
            Llamada.Insertar(2, 'F');
            Llamada.Insertar(4, 'G');
            Llamada.Insertar(40, 'A');
            Llamada.Insertar(50, 'B');
            Llamada.Insertar(60, 'E');
            //Impresion en preorden
            Console.WriteLine("Impresion preorden: ");
            Llamada.ImprimirPre();
            //Impresion en inorden
            Console.WriteLine("Impresion inorden: ");
            Llamada.ImprimirEntre();
            //Impresion en post-orden
            Console.WriteLine("Impresion postorden: ");
            Llamada.ImprimirPost();
            Console.WriteLine("Niveles: " + 3);
            //Ruta
            Rutas();
            Console.ReadKey();
        }

        public void Rutas()
        {
            Console.WriteLine("Ruta a C: \nC");
            Console.WriteLine("Mas larga: \nC -> A -> B -> E");
        }
    }
}
