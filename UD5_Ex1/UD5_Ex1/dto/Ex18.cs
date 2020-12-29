using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex18
    {
        /*
         * 18) Crea un array de números donde le indicamos por teclado el tamaño del array,
            rellenaremos el array con números aleatorios entre 0 y 9, al final muestra por pantalla el
            valor de cada posición y la suma de todos los valores. Haz un método para rellenar el array
            (que tenga como parámetros los números entre los que tenga que generar), para mostrar el
            contenido y la suma del array y un método privado para generar número aleatorio (lo
            puedes usar para otros ejercicios).
        */


        public static void PrintaIndiceArrayInt(int[] cadena)
        {
            Console.WriteLine("Índice   Valor");
            for (int x = 0; x < cadena.Length; x++)
            {
                Console.WriteLine("{0}          {1}", x, cadena[x]);
            }
        }

        public static int SumaPosicionesArrayInt(int[] cadena)
        {
            int sumaTotal = 0;

            for (int x = 0; x < cadena.Length; x++)// recorremos las posiciones del array
            {
                sumaTotal += Convert.ToInt32(cadena[x]); //sumamos recursivamente los valores del array.
            }
            return sumaTotal;
        }

    }
}
