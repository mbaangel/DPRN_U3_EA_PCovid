// UNADM 
// PROGRAMACIÓN .NET 1 (DS-DPRN1-2102-B1-001)
// Docente Mtra.Alejandra Osti Flores
// Alumno Miguel Angel Morales Rutilo ES1822025493

using System;
using System.Globalization;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DPRN_U3_AC_MIMR
{
    class Program
    {
        int Ancho, n, i, Alto, auxiliar, numero, par, impar;
        //char a;
        //string linea;
        //private int[,] mat;
        string nombre, edad, genero, vacunaCovid, correo, boletaBinario, numeroSuerte;

        void Inicializar() // En el siguiente método desarrollaremos el menú de ingreso de datos.
        {
            Console.WriteLine("****************************");
            Console.WriteLine("**BASE DE DATOS DE ALUMNOS**");
            Console.WriteLine("****************************");
            Console.Write("Ingresa el nombre del alumno: ");
            Console.ReadLine();
            nombre = Console.ReadLine();
            Console.Write("Edad: ");
            edad = Console.ReadLine();
            Console.Write("Genero: ");
            genero = Console.ReadLine();
            Console.Write("Vacuna Covid: ");
            vacunaCovid = Console.ReadLine();
            Console.Write("correo: ");
            correo = Console.ReadLine();
            Console.Write("Boleta en binario: ");
            boletaBinario = Console.ReadLine();
            Console.Write("Numero de la suerte: \n");
            numeroSuerte = Console.ReadLine();

            if (boletaBinario == "uno")
            {
                //boletaBinario = "1";
                Console.WriteLine("1");
                //numero = numero / 2;
                //numero = numero + 1;
            }
            else if (boletaBinario == "cero")
            {
                Console.WriteLine("0");
                //boletaBinario = "0";
                //Console.WriteLine(" el numero " + numero + " es impar");
                //numero = numero / 2;
                //numero = numero + 1;

            }

            Console.WriteLine("Nombre: " + nombre + "\nEdad: " + edad + "\nGénero:  " + genero+ "\nVacuna Covid: " + vacunaCovid + "\nCorreo: " + correo +"\nBoleta: "+boletaBinario +"\nNúmero de la Suerte: "+ numeroSuerte + "\n");

            Console.WriteLine("Pulse 0 para vovler al menú principal.");

        }

            void metodoCalculo() //El segundo método incluye la estructura de control para la realización del ejercicio.
            {
                Console.WriteLine("**CÁLCULO EVALUAR UN NÚMERO POSITIVO**");
                Console.Write("Ingresa el número positivo: ");
                Console.ReadLine();
                numero = int.Parse(Console.ReadLine());

            }


            void metodoImprimir() // Este método sigue el flujo.
            {
            Console.WriteLine("Nombre: " + nombre + " " + edad + " " + genero + vacunaCovid + correo + boletaBinario + numeroSuerte +"\n");
            }

            void metodoGuardar() // Este método sigue el flujo.
            {
                Console.WriteLine("\n¡Hasta pronto!\n");
            }

            void metodoSalir() // Este método sigue el flujo.
            {
                Console.WriteLine("\n¡Hasta pronto!\n");
            }

            
            static void Main(string[] args) //Este es el método MAIN el cual permite tener un orden de ejecución de los métodos-funciones, estructuras selectivas.
            {

                //submenu = int.Parse(Console.ReadLine());

                {
                    Program c1 = new Program();

                    Console.Title = " * ***DPRN_U3_MIMR****";
                    Console.WriteLine("****************************");
                    Console.WriteLine("**BASE DE DATOS DE ALUMNOS**");
                    Console.WriteLine("****************************");
                    Console.WriteLine("Seleccione la opción (1-2):");
                    Console.Write("\n1. Ingresar a la base de datos" + "\n2. Realizar cálculos internos" + "\n3. Realizar cálculos internos" + "\n4. Realizar cálculos internos" + "\n5. Salir\n");
                    Console.Write("\nSeleccione una opción: ");

                

                    switch (Console.Read())
                    {
                        case '1':
                            //Console.Clear();
                            c1.Inicializar();
                            c1.metodoCalculo();
                            c1.metodoImprimir();
                            c1.metodoGuardar();
                            c1.metodoSalir();

                            Console.WriteLine("\n¡Hasta pronto!\n");
                            break;
                        case '2':
                            c1.metodoCalculo();

                            Console.WriteLine("\n¡Hasta pronto!\n");
                            break;
                        case '3':
                            c1.metodoImprimir();
                            Console.WriteLine("\n¡Hasta pronto!\n");
                            break;
                        case '4':
                            c1.metodoGuardar();
                            Console.Write("Información guardada en sistema");
                            Console.WriteLine("\n¡Hasta pronto!\n");
                            break;
                        case '5':
                            c1.metodoSalir();
                            Console.WriteLine("\n¡Hasta pronto!\n");
                            break;
                        default:
                            Console.WriteLine("\nRespuesta invalida\n");

                            break;
                    }
                    Console.ReadKey();

                }
            }
        
    }
}
