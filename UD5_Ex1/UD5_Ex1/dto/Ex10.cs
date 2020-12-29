using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Ex10
    {
        /*10) Hacer la tabla de un numero pedido por teclado hasta el 10. (5*0, 5*1 … 5*10).
             Muestra el contenido.*/

        public static void TablaMultiplicar()
        {
            Console.WriteLine("¿Qué tabla deseas ver? Escribe un número:");
            int tabla = Convert.ToInt32(Console.ReadLine());

            PrintadorTablas(CreadorTablas(tabla)); //llamamos al metodo para printar la tabla y le pasamos como parametro el metodo creador de tablas.
        }

        // metodo para crear una matriz multidimensional
        public static int[,] CreadorTablas(int numero)
        {
            int[,] tabla = new int[11, 3]; // creamos una array con 11 filas (del 0 al 10) y 3 columnas (numero que buscamos, posicion actual del 0 al 10, producto)

            for (int x = 0; x<tabla.GetLength(0); x++) //.GetLenght(0) coge como tope maximo la longitud de la tabla
            {
                tabla[x, 0] = numero;
                tabla[x, 1] = x;
                tabla[x, 2] = numero * x;
            }
            
            return tabla; // devolvemos la tabla multidimensional
        }

        // metodo para printar una matriz multidimensional        
        public static void PrintadorTablas(int[,] tabla)
        {
            for (int x = 0; x < tabla.GetLength(0); x++) // recorremos toda la tabla y printamos.
            {
                Console.WriteLine("{0} x {1} = {2} \n", tabla[x, 0], tabla[x, 1], tabla[x, 2]);                
            }
        }


    }
}
