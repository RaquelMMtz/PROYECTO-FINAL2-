using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Consola
{
    class Program
    {
        static void Main(string[] args)
        {
            string Cadena;
            int DatoEntero;
      
            Char opcion;
            string continuar;


          
            Console.Write("¿Como te llamas?: ");
            Cadena = Console.ReadLine();
            Console.Write("¿Cuantos años tienes?: ");
            DatoEntero = Convert.ToInt32(Console.ReadLine());
  
            Console.WriteLine("Tu nombre: " + Cadena);
            Console.WriteLine("Tu edad: " + DatoEntero.ToString());
            do
            {
                Console.WriteLine("|************************************************************************************|");
                Console.WriteLine("|*                                                                                  *|");
                Console.WriteLine("|*                    1.-Suma de dos numeros          ( x + y)                      *|");
                Console.WriteLine("|*                    2.-Resta de dos numeros         ( x - y)                      *|");
                Console.WriteLine("|*                    3.-Multiplicacion de dos numeros( x + y)                      *|");
                Console.WriteLine("|*                    4.-Division de dos numeros      ( x + y)                      *|");
                Console.WriteLine("|*                    5.-Todas las operaciones        ( x + y)                      *|");
                Console.WriteLine("|*                                                                                  *|");
                Console.WriteLine("|*                    0.Salir                                                       *|");
                Console.WriteLine("|************************************************************************************|");
                Console.Write("\n");
                Console.Write("Dime una opcion:  ");

                do
                {
                    opcion = Console.ReadKey(true).KeyChar;
                }
                while (opcion < '0' || opcion > '5');
                switch (opcion)
                {
                    case '0':
                        {
                            Environment.Exit(0);
                        }
                        break;

                    case '1':
                        {
                            Console.Write("(0)\n", opcion);
                            Console.WriteLine("-----------------------------------");

                            Console.Write("Ingrese primer numero (x): ");
                            double numerox = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo numero (y): ");
                            double numeroy = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------------");
                            Operaciones op = new Operaciones(numerox, numeroy);

                            Console.WriteLine("El resultado de la suma es:" + op.opsuma().ToString());
                        }
                        break;
                    case '2':
                        {
                            Console.Write("(0)\n", opcion);
                            Console.WriteLine("-----------------------------------");

                            Console.Write("Ingrese primer numero (x): ");
                            double numerox = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo numero (y): ");
                            double numeroy = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------------");
                            Operaciones op = new Operaciones(numerox, numeroy);

                            Console.WriteLine("El resultado de la resta es:" + op.opresta().ToString());
                        }
                        break;
                    case '3':
                        {
                            Console.Write("(0)\n", opcion);
                            Console.WriteLine("-----------------------------------");

                            Console.Write("Ingrese primer numero (x): ");
                            double numerox = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo numero (y): ");
                            double numeroy = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------------");
                            Operaciones op = new Operaciones(numerox, numeroy);

                            Console.WriteLine("El resultado de la multiplicacion es:" + op.opmultiplicar().ToString());
                        }
                        break;
                    case '4':
                        {
                            Console.Write("(0)\n", opcion);
                            Console.WriteLine("-----------------------------------");

                            Console.Write("Ingrese primer numero (x): ");
                            double numerox = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo numero (y): ");
                            double numeroy = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------------");
                            Operaciones op = new Operaciones(numerox, numeroy);

                            Console.WriteLine("El resultado de la division es:" + op.opdividir().ToString());
                        }
                        break;
                    case '5':
                        {
                            Console.Write("(0)\n", opcion);
                            Console.WriteLine("-----------------------------------");

                            Console.Write("Ingrese primer numero (x): ");
                            double numerox = double.Parse(Console.ReadLine());

                            Console.Write("Ingrese segundo numero (y): ");
                            double numeroy = double.Parse(Console.ReadLine());

                            Console.WriteLine("-------------------------------------");
                            Operaciones op = new Operaciones(numerox, numeroy);

                            Console.WriteLine("El resultado de la suma es:    " + op.opsuma().ToString());
                            Console.WriteLine("El resultado de la resta es:   " + op.opresta().ToString());
                            Console.WriteLine("El resultado de la multiplicacion es:  " + op.opmultiplicar().ToString());
                            Console.WriteLine("El resultado de la division es:   " + op.opdividir().ToString());
                        }
                        break;
                }

                Console.WriteLine("------------------------------------------------------------------------------");
                Console.Write("¿Deseas continuar? y/n");
                continuar = Console.ReadLine();
                Console.WriteLine("\n");
                Console.Clear();
            }
            while (continuar != "n");
        }
    }
}


