using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2_Arboles
{
    class Arbol1
    {
        public void MetodoArbol1()
        {
            Arbol Llamada = new Arbol(); //Se crea un objeto de la clase arbol
            //Se insertan datos en nuestro arbol
            Llamada.Insertar(10, 'E');
            Llamada.Insertar(4, 'A');
            Llamada.Insertar(3, 'B');
            Llamada.Insertar(2, 'C');
            Llamada.Insertar(5, 'D');
            Llamada.Insertar(20, 'F');
            //Impresion en preorden
            Console.WriteLine("Impresion preorden: ");
            Llamada.ImprimirPre();
            //Impresion en inorden
            Console.WriteLine("Impresion inorden: ");
            Llamada.ImprimirEntre();
            //Impresion en post-orden
            Console.WriteLine("Impresion postorden: ");
            Llamada.ImprimirPost();
            Console.WriteLine("Niveles: " + 2);
            //Ruta
            Rutas();
            Console.ReadKey();
        }
        public void Rutas()
        {
            Console.WriteLine("Ruta a C: \nE -> A -> C");
            Console.WriteLine("Mas larga: \nE -> A -> B");
        }
    }
}

