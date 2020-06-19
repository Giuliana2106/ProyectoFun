using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Funciones
{
    class Program
    {

        static string[,] agenda = new string[4, 10];
        static int Contador = 0;
        static void Main(string[] args)
        {

            agenda = new string[4, 10];

            for(int f=0;f<10;f++)
            {
                Console.Write("Ingrese nombre: ");
                agenda[0, f] = Console.ReadLine();

                Console.Write("Ingrese apellido: ");
                agenda[1, f] = Console.ReadLine();

                Console.Write("Ingrese dirección: ");
                agenda[2, f] = Console.ReadLine();

                Console.Write("Ingrese teléfono: ");
                agenda[3, f] = Console.ReadLine();

            }


            Console.WriteLine("\n");

            GuardarContacto();

            MostrarContactos();



            BuscarModificarEliminar('1');

            BuscarModificarEliminar('2');

            MostrarContactos();

            BuscarModificarEliminar('3');

            Console.ReadKey();

        }



        static int PedirNoContactos()

        {

            Console.Write("Cuantos contactos desea agregar: ");

            return int.Parse(Console.ReadLine());

        }

        static string PedirDatos(string linea)

        {

            string dato = "";

            dato = "Ingrese " + linea + " : ";

            return dato;

        }

        static void GuardarContacto()

        {

            if (Contador < 10)

            {

                Console.Write(PedirDatos("Nombre"));

                agenda[0, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Apellido"));

                agenda[1, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Direccion"));

                agenda[2, Contador] = Console.ReadLine();

                Console.Write(PedirDatos("Telefono"));

                agenda[3, Contador] = Console.ReadLine();

                Contador++;

                Console.WriteLine("\n");

            }

            else

            {

                Console.WriteLine("Agenda llena\n");

            }

        }

        static void BuscarModificarEliminar()
        {
            string buscar = "";
            Console.Write("Ingrese nombre del contacto: ");
            buscar = Console.ReadLine();
        }

        static void MostrarContactos()

        {

            for (int f = 0; f < Contador; f++)

            {

                Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f] + "\n");

            }

        }

        static void BuscarModificarEliminar(char tipo)

        {

            string buscar = "";
            Console.Write("Ingrese nombre del contacto: ");
            buscar = Console.ReadLine();

            for (int f = 0; f < 10; f++)

            {

                if (tipo == '1')

                {

                    if (buscar == agenda[0, f])

                    {

                        Console.WriteLine(agenda[0, f] + "--" + agenda[1, f] + "--" + agenda[2, f] + "--" + agenda[3, f]);

                    }

                }

                else if (tipo == '2')

                {

                    if (buscar == agenda[0, f])

                    {

                        Console.Write(PedirDatos("Nombre"));

                        agenda[0, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Apellido"));

                        agenda[1, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Direccion"));

                        agenda[2, f] = Console.ReadLine();

                        Console.Write(PedirDatos("Telefono"));

                        agenda[3, f] = Console.ReadLine();

                    }

                }

                else

                {

                    if (buscar == agenda[0, f])

                    {

                        agenda[0, f] = " ";

                        agenda[1, f] = " ";

                        agenda[2, f] = " ";

                        agenda[3, f] = " ";
                    }

                }

            }

        }

    }

} 
