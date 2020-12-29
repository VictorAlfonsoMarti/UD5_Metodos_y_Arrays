using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex16
    {
        // 16) Indicar si un array de números es capicua. Es capicua cuando coincide el
        // primero y el ultimo elemento, el segundo y el penúltimo y así sucesivamente.

        public static Boolean EsCapicua(string[] cadena)
        {
            Boolean resultadoCapicua = false;

            // declaramos la primera y la última posicion en variables
            int posicionX = 0;
            int posicionY = cadena.Length -1;

            // recorremos el array
            for (int x = 0; x < cadena.Length; x++)
            {
                if (cadena[posicionX].Equals(cadena[posicionY]) && posicionX <= posicionY) // comprobamos la igualdad y que la posicion a comprobar no se pasen la una de la otra
                {
                    resultadoCapicua = true; 
                    // modificamos posiciones
                    posicionX++;
                    posicionY--;
                }
                else break;
            }
            return resultadoCapicua;
        }

    }
}
