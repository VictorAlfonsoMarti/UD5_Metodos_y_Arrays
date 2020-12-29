using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex17
    {
        /*17) Crea un array de 10 posiciones de números con valores pedidos por teclado. Muestra
        por consola el índice y el valor al que corresponde. Haz dos métodos, uno para rellenar
        valores y otro para mostrar.*/
        public static void PrintaIndiceArray(string[] cadena)
        {
            Console.WriteLine("Índice   Valor");
            for (int x = 0; x <cadena.Length; x++)
            {
                Console.WriteLine("{0}          {1}", x, cadena[x]);
            }
        }
    }
}
