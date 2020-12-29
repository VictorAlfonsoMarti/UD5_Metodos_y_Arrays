using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex8
    {
        /*
         * 8) Crear un array de números con la longitud que quieras e introducir en cada
        elemento el valor su posición. Muestra el contenido.
        */

        public static int[] CrearArray()
        {
            Console.WriteLine("Creadora de Arrays: ¿Cuántas celdas quieres tener?");
            int nCeldas = Convert.ToInt32(Console.ReadLine()); // recogemos la cantidad de celdas que tiene que tener el array

            int[] arrayCreado = new int[nCeldas]; // creamos un array vacio con las celdas que nos han indicado

            for (int x = 0; x < nCeldas; x++) // recorremos todas las celdas del array
            {
                arrayCreado[x] = x;
            }

            return arrayCreado; // devolvemos cada una de las celdas del array en formato array.
        }
    }
}
