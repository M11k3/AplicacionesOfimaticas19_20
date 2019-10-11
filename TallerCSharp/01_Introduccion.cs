using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _01TallerCSharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declaracion variables
            //byte , short , int , long , float , double
            /* Esto 
             * es un comentario
             * de Varias lineas
             */


            int posicion = 0; 
            //Variables no inicializadas -> no tienen valor
            int posicion2 = posicion + 1;

            float temperatura = 15.8f;
            float temperatura2 = (float)15.9;
            //  float temperatura3 = Convert.ToSingle(15.8);

            int numero = 50;
            byte numeroByte = (byte)numero;

            double velocidad = 50.567;
            float velocidadFloat = (float)velocidad;


            byte n1 = 9, n2 = 1;
            byte suman1yn2 = (byte)(n1 + n2);

            //Constantes
            const double C= 3.983737373;

            //Librería Math = igual que en VB

            //Mostrar por pantalla
            Console.WriteLine("Este es un mensaje");
            Console.WriteLine("La variable suma = " + suman1yn2);

            //Operadores
            // Comparacion de igualdad ==
            // Resto de la división entera = %
            //Operadores lógicos:
            //And --> &&
            //Or --> ||
            //Not -->!

            //+= , -= ...

            //++ , --
            int n = 9;
            n++;
            n--;

            //if else
            int variable = 9;

            //Ver si variable es par

            if (variable % 2 == 0)
            {
                Console.WriteLine("Par");
            }
                  else
            {
                Console.WriteLine("Impar");
            }


            int edad;
            Console.WriteLine("Dime tu edad:");
            edad = Convert.ToInt32(Console.ReadLine());


            Console.ReadLine();
            
        }
    }
}
