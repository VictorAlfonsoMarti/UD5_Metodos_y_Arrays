using System;
using System.Collections.Generic;
using System.Text;

namespace UD5_Ex1_Ex21
{ 
    class Ex7
    {
    /*7) Crea un aplicación de consola que nos convierta una cantidad de euros introducida por
        teclado a otra moneda, estas pueden ser a dolares, yenes o libras. El método tendrá como
        parámetros, la cantidad de euros y la moneda a pasar que sera una cadena, este no
        devolverá ningún valor, mostrara un mensaje indicando el cambio (void).
        
        El cambio de divisas son:
            • 0.86 libras es un 1 €
            • 1.28611 $ es un 1 €
            • 129.852 yenes es un 1 €
    */

    static public void ConversorMoneda()
    {
        Console.WriteLine("Conversor de euros a dolares, yenes o libras. \n Indica la cantidad de euros que deseas convertir: ");
        double cantidad = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Indica en qué moneda deseas realizar la conversión: dolares || yenes || libras ");
        string moneda = Console.ReadLine();

        switch (moneda) // ejecuta el conversor segun la moneda indicada
        {
            case "dolares":
                Console.WriteLine(EuroDolar(cantidad));
                break;
            case "yenes":
                Console.WriteLine(EuroYen(cantidad));
                break;
            case "libras":
                Console.WriteLine(EuroLibra(cantidad));
                break;
            default:
                Console.WriteLine("ERROR: No se reconoce la moneda.");
                break;
        }
    }

    static public double EuroDolar(double euros) //conversor de euros a dolares
    {
        return euros * 1.28611;
    }
    static public double EuroYen(double euros) // converor de euros a yenes
    {
        return euros * 129.852;
    }
    static public double EuroLibra(double euros) // conversor de euros a libras
    {
        return euros * 0.86;
    }

    }
}
