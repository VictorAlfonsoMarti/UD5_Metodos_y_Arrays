using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    public class Ex9
    {
        /*
         * 9) Crear un array de numeros con la longitud que quieras y pedir al usuario que en
                cada elemento inserte un numero. Muestra el contenido.
        */
        public static string[] CrearArrayPersonalizado()
        {
            Console.WriteLine("Creadora de Arrays: ¿Cuántas celdas quieres tener?");
            int nCeldas = Convert.ToInt32(Console.ReadLine()); // recogemos la cantidad de celdas que tiene que tener el array

            string[] arrayCreado = new string[nCeldas]; // creamos un array vacio con las celdas que nos han indicado

            for (int x = 0; x < nCeldas; x++) // recorremos todas las celdas del array
            {
                Console.WriteLine("Qué valor numérico quieres insertar en la posicion {0}?", x + 1);
                arrayCreado[x] = Console.ReadLine(); //insertamos el valor que nos introducen, al ser todo string nos recoge numeros y letras.
            }

            Console.WriteLine("\n \n Array creado con exito.");
            return arrayCreado; // retornamos el array para utilizarlo en futuros ejercicios (Ej. ejercicio 11).
        }

        // Crearemos la vista del array a parte para poder utilizar el metodo crear array personalizado en otras clases. 
        public static void MostrarArray(string[] arrayCreado)
        {
            Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", arrayCreado)); // printamos cada una de las celdas del array en formato array.
        }
    }
}
