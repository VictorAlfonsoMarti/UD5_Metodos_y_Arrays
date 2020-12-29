using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{
    class Selector
    {
        // selector de ejercicios. ejecuta métodos según el ejercicio que se quiera comprobar.
        public static void SelectorEjercicio()
        {
            Console.WriteLine("Indica el ejercicio que quieres ejecutar: (Número del 1 al 21)");
            string ejercicio = Console.ReadLine();

            switch (ejercicio) //ejecutamos el método según el ejercicio.
            {
                case "1":
                    Ex1.CalcularAreas();
                    break;
                case "2":
                    Ex2.GeneradorNumeros();
                    break;
                case "3":
                    Ex3.EsPrimo();
                    break;
                case "4":
                    Ex4.PrintaFactorial();
                    break;
                case "5":
                    Ex5.PrintBinario();
                    break;
                case "6":
                    Ex6.PrintNumeroCifras();
                    break;
                case "7":
                    Ex7.ConversorMoneda();
                    break;
                case "8":
                    int[] arrayCreado = Ex8.CrearArray();
                    Console.WriteLine("\n \n Array creado con exito. \n [{0}]", string.Join(", ", arrayCreado));
                    break;
                case "9":
                    Ex9.MostrarArray(Ex9.CrearArrayPersonalizado());
                    break;
                case "10":
                    Ex10.TablaMultiplicar();
                    break;
                case "11":
                    int sumaTotalArray = Ex11.SumaPosicionesArray(Ex9.CrearArrayPersonalizado());
                    Console.WriteLine("La suma total del array es de: {0}", sumaTotalArray);
                    break;
                case "12":
                    int mediaCadena = Ex12.MediaPosicionesArray(Ex9.CrearArrayPersonalizado());
                    Console.WriteLine("La media total del array es de: {0}", mediaCadena);
                    break;
                case "13":
                    Ex9.MostrarArray(Ex13.ArrayAleatorio());
                    break;
                case "14":
                    string[] cadenaAleatoria = Ex13.ArrayAleatorio();
                    if (Ex14.ExisteEnArray(cadenaAleatoria)) // el metodo ExisteEnArray nos da un boolean, printamos en consecuencia. 
                    {
                        Console.WriteLine("Sí existe.");
                        Ex9.MostrarArray(cadenaAleatoria); // mostramos el array para comprobar que es correcto
                    }
                    else
                    {
                        Console.WriteLine("No Existe");
                        Ex9.MostrarArray(cadenaAleatoria);
                    }
                    break;
                case "15":
                    string[] cadenaAnverso = Ex13.ArrayAleatorio(); //generamos array aleatorio
                    string[] cadenaReverso = Ex15.InvertirArray(cadenaAnverso); //lo pasamo al reves

                    Console.WriteLine("Array:");
                    Ex9.MostrarArray(cadenaAnverso); // printamos array correcto
                    Console.WriteLine("Array del revés:");
                    Ex9.MostrarArray(cadenaReverso); // printamos array del revés
                    break;
                case "16":
                    string[] cadenaCapicua = Ex9.CrearArrayPersonalizado(); // creamos un array personalizado
                    Boolean resultadoCapicua = Ex16.EsCapicua(cadenaCapicua); // ejecutamos metodo de comprobación
                    Ex9.MostrarArray(cadenaCapicua); //mostramos por mantalla
                    if (resultadoCapicua) Console.WriteLine("Sí es capicua.");
                    else Console.WriteLine("No es capicua");
                    break;
                case "17":
                    string[] cadenaIndiceValor = Ex9.CrearArrayPersonalizado(); // creamos array personalizado
                    Ex17.PrintaIndiceArray(cadenaIndiceValor); // printamos los indices y los valores del array.
                    break;
                case "18":
                    Console.WriteLine("¿De qué tamaño quieres el array? Indica un número: ");
                    int[] cadena09 = Ex2.NumeroRandom(Convert.ToInt32(Console.ReadLine()),0,9); //guardamos en variable un array generada con un metodo
                    Ex18.PrintaIndiceArrayInt(cadena09); // printamos el array
                    int sumaCadena09 = Ex18.SumaPosicionesArrayInt(cadena09); // guardamos el valor de la suma por metodo
                    Console.WriteLine("La suma total de las posiciones es de: {0}", sumaCadena09);
                    break;
                case "19":
                    Console.WriteLine("¿De qué tamaño quieres el array? Indica un número: ");
                    int tamañoArrayPrimo = Convert.ToInt32(Console.ReadLine());
                    Console.WriteLine("Indica el número mínimo:");
                    int minArrayPrimo = Convert.ToInt32(Console.ReadLine()); ;
                    Console.WriteLine("Indica el número máximo:");
                    int maxArrayPrimo = Convert.ToInt32(Console.ReadLine()); ;

                    int[] cadenaPrimo = Ex19.NumeroRandomPrimo(tamañoArrayPrimo, minArrayPrimo, maxArrayPrimo);
                    Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", cadenaPrimo)); // printamos cada una de las celdas del array en formato array.

                    Console.WriteLine("El número mayor del array es el: {0}", Ex19.NumeroMayorArray(cadenaPrimo)); // ejecutamos metodo de numero mayor  printamos
                    break;
                case "20":
                    Console.WriteLine("Creadora de Arrays Aleatorios: ¿Cuántas celdas quieres tener?");
                    int[] cadenaA = Ex20.ArrayAleatorioInt(Convert.ToInt32(Console.ReadLine()));
                    int[] cadenaB = cadenaA;
                    cadenaA = Ex20.ArrayAleatorioInt(cadenaA.Length);

                    int[] cadenaC = Ex20.MultiplicadorArray(cadenaA, cadenaB);

                    Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", cadenaA)); // printamos cada una de las celdas del array en formato array.
                    Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", cadenaB)); // printamos cada una de las celdas del array en formato array.
                    Console.WriteLine("\n Tu array es: [{0}]", string.Join(", ", cadenaC)); // printamos cada una de las celdas del array en formato array.
                    break;
                case "21":
                    Ex21.ExtractorValorArrayExacto();
                    break;
                default:
                    Console.WriteLine("ERROR: Debes introducir un número del 1 al 21.");
                    SelectorEjercicio(); // llamamos otra vez al selector.
                    break;               
            }


            // comprobamos si queres ejecutar más ejercicios
            Console.WriteLine("\n \n ¿Quieres comprobar otra vez algún ejercicio? si || no ");
            string salir = Console.ReadLine();

            if (salir == "si") SelectorEjercicio();
            else System.Environment.Exit(1);


        }
    }
}
