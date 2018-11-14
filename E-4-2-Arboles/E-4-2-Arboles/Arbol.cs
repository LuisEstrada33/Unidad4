using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2_Arboles
{
    
        public class Nodo
        {
            public int info; //Valor del nodo
            public Nodo izq, der; //Punteros 
            public char letra; //Char del nodo
        }

        public class Arbol
        {
            Nodo raiz; //Se crea el objeto raiz

            public Arbol()
            {
                raiz = null; //El constructor inicializa raiz en nulo
            }

        public void Insertar(int info, char letra)
        {
            
            Nodo nuevo = new Nodo //Se inicializa nuevo de parte de Nodo
            {
                info = info, //Se agrega el valor al nodo
                letra = letra, //Se agrega la letra al nodo
                izq = null,
                der = null
            };
                if (raiz == null)
                    raiz = nuevo; //Si raiz es nulo, se le asigna el primer valor ingresado
                else //De lo contrario se evaluan los valores de los nodos para ir acomodandolos
                {
                    Nodo anterior = null, recorrido;
                    recorrido = raiz;
                    while (recorrido != null)
                    {
                        anterior = recorrido;
                        if (info < recorrido.info)
                            recorrido = recorrido.izq;
                        else
                            recorrido = recorrido.der;
                    }
                    if (info < anterior.info)
                        anterior.izq = nuevo;
                    else
                        anterior.der = nuevo;
                }
            }


            private void ImprimirPre(Nodo recorrido) //Se imprime el pre orden
            {
                if (recorrido != null)
                {
                    Console.Write(recorrido.letra + " ");
                    ImprimirPre(recorrido.izq);
                    ImprimirPre(recorrido.der);
                }
            }

            public void ImprimirPre()
            {
                ImprimirPre(raiz);
                Console.WriteLine();
            }

            private void ImprimirEntre(Nodo recorrido) //Se imprime el inorden
            {
                if (recorrido != null)
                {
                    ImprimirEntre(recorrido.izq);
                    Console.Write(recorrido.letra + " ");
                    ImprimirEntre(recorrido.der);
                }
            }

            public void ImprimirEntre()
            {
                ImprimirEntre(raiz);
                Console.WriteLine();
            }


            private void ImprimirPost(Nodo recorrido) //Se imprime el post-orden
            {
                if (recorrido != null)
                {
                    ImprimirPost(recorrido.izq);
                    ImprimirPost(recorrido.der);
                    Console.Write(recorrido.letra + " ");
                }
            }
            public void ImprimirPost()
            {
                ImprimirPost(raiz);
                Console.WriteLine();
            }
        }
    
}
