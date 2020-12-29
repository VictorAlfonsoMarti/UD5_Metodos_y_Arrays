using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex12
    {
        /* 12) Crear un array de 10 posiciones, añadir el valor en cada una de sus posiciones y
               sacar la media.*/
        public static int MediaPosicionesArray(string[] cadena)
        {
           int mediaCadena = Ex11.SumaPosicionesArray(cadena);
           return mediaCadena/2;
        }
    }
}
