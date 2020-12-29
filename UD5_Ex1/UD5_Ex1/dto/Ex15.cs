using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex15
    {
        //15) Invertir los valores de un array y meterlos en otro array.

        public static string[] InvertirArray(string[] cadena)
        {
            string[] cadenaInvertida = new string[cadena.Length]; // creamos un array nuevo con el mismo tamaño que el array entrante.
            
            // declaramos una variable y que tenga de valor el tamaño del array(-1 por que la primera posicion vale 0) para poder usar como marcador de posición al nuevo array
            int y = cadena.Length -1;  

            for (int x = 0; x < cadena.Length; x++) //recorremos un array
            {
                cadenaInvertida[x] = cadena[y]; // ponemos el valor de la posicion y (la última) del array principal en la posicion x(la primera) del array nuevo.   
                y--; // restamos a la posición y
            }
            return cadenaInvertida;
        }
    }
}
