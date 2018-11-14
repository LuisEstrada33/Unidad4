using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace E_4_2_Arboles
{
    class Program
    {
        static void Main(string[] args)
        {
            int opcion = 1; 
            while (opcion != 4) 
            {
               
                    Console.WriteLine("Seleccione un arbol: \n1.- Árbol 1 \n2.- Árbol 2 \n3.- Árbol 3 \n4.- Salir");
                    opcion = Convert.ToInt32(Console.ReadLine());
                    switch (opcion)
                    {
                        case 1:
                            Console.Clear();
                            Arbol1 Arbol1 = new Arbol1(); //Arbol 1
                            Arbol1.MetodoArbol1();
                            break;
                        case 2:
                            Console.Clear();
                            Arbol2 Arbol2 = new Arbol2(); //Arbol 2
                            Arbol2.MetodoArbol2();
                            break;
                        case 3:
                            Console.Clear();
                            Arbol3 Arbol3 = new Arbol3(); //Arbol 3
                            Arbol3.MetodoArbol3();
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Ingrese opcion válida"); //Opcion no valida
                            break;

                    }
                
            
            }
        }
    }
}
