using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace proyectoSemana7_biblioteca
{
    internal class Test
    {
        static void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            // Se precargan algunos libros y lectores por código para probar los métodos.

            biblioteca.agregarLibro("Cuentos de la Selva", "Horacio Quiroga", "Cooperativa editorial Buenos Aires");
            biblioteca.agregarLibro("El Quijote", "Miguel de Cervantes", "Alfaguara");
            biblioteca.agregarLibro("La Divina Comedia", "Dante Alighieri", "Planeta");
            biblioteca.agregarLibro("Hamlet", "William Shakespeare", "Alianza Editorial");
            biblioteca.agregarLibro("Tuya", "Claudia Piñeiro", "Alfaguara");
            biblioteca.agregarLibro("Angeles y Demonios", "Dan Browin", "NiIdea");
            biblioteca.agregarLibro("Una misma noche", "Leopoldo Brizuela", "Alfaguara");
            biblioteca.agregarLibro("Cadaver exquisito", "Agustina Bazterrica", "Alfaguara");
            biblioteca.AltaLector("Marcos", 11111111);
            biblioteca.AltaLector("Sandra", 22222222);
            biblioteca.AltaLector("Maria", 33333333);
            biblioteca.AltaLector("Roberto", 44444444);
            biblioteca.AltaLector("Madelaine", 55555555);
            biblioteca.AltaLector("Martin", 66666666);
            biblioteca.AltaLector("Mariano", 77777777);
            biblioteca.AltaLector("Lorena", 88888888);
            biblioteca.AltaLector("Pablo", 99999999);


            Console.WriteLine("¿Qué operación que desea realizar?");
            Console.WriteLine(" ");
            Console.WriteLine("1.-  Ingresar Libros");
            Console.WriteLine("2.-  Dar de alta un Lector");
            Console.WriteLine("3.-  Generar un préstamo");

            string nroAccion = Console.ReadLine();

            while (nroAccion.Length != 1)
            {
                Console.WriteLine("No ha ingresado una opción correcta.");
                Console.WriteLine("Seleccione la operación que desea realizar");
                Console.WriteLine(" ");
                Console.WriteLine("1.-  Ingresar Libros");
                Console.WriteLine("2.-  Dar de alta un Lector");
                Console.WriteLine("3.-  Generar un préstamo");
                nroAccion = Console.ReadLine();
            }    

            switch (letraAccion)
            {
                case "1":
                    Console.WriteLine("Iniciará la carga de libros al inventario");
                    Console.WriteLine("Ingrese \"FIN\" como TITULO para terminar");
                    string tituloAAgregar;
                    do
                    {
                        Console.Write("Ingrese el TITULO del libro: ");
                        tituloAAgregar = Console.ReadLine().ToUpper();
                        if (tituloAAgregar != "FIN")
                        {
                            Console.Write("Ingrese el AUTOR del libro: ");
                            string autorAAgregar = Console.ReadLine();
                            Console.Write("Ingrese la EDITORIAL del libro: ");
                            string editorialAAgregar = Console.ReadLine();

                            bool libroAgregado = biblioteca.agregarLibro(tituloAAgregar, autorAAgregar, editorialAAgregar);
                            if (libroAgregado == true)
                            {
                                Console.WriteLine($"El libro {tituloAAgregar} del autor {autorAAgregar} impreso por la editorial {editorialAAgregar} se agregó CORRECTAMENTE");
                            }
                            else
                            {
                                Console.WriteLine($" NO SE PUDO AGREGAR al libro {tituloAAgregar} del autor {autorAAgregar} impreso por la editorial {editorialAAgregar}");
                            }
                        }
                    } while (tituloAAgregar != "FIN");
                    break;


                case "2":
                    Console.WriteLine("Iniciará el alta de nuevos lectores");
                    Console.WriteLine("Ingrese \"FIN\" como NOMBRE para terminar");
                    string nombreAAgregar;
                    do
                    {
                        Console.Write("Ingrese los NOMBRE/s y APELLIDO/s del nuevo lector: ");
                        nombreAAgregar = Console.ReadLine().ToUpper();
                        if (nombreAAgregar != "FIN")
                        {
                            Console.Write("Ingrese el DNI del nuevo lector: ");
                            int dniAAgregar = int.Parse(Console.ReadLine());

                            bool lectorCargado = biblioteca.AltaLector(nombreAAgregar, dniAAgregar);
                            if (lectorCargado == true)
                            {
                                Console.WriteLine($"El lector {nombreAAgregar} con DNI {dniAAgregar} fue dado de alta CORRECTAMENTE");
                            }
                            else
                            {
                                Console.WriteLine($" NO SE PUDO DAR DE ALTA al lector {nombreAAgregar} cuyo DNI es {dniAAgregar}.");
                            }
                        }
                    } while (nombreAAgregar != "FIN");
                    break;


                case "3":
                    Console.WriteLine("Generará nuevos préstamos.");
                    Console.WriteLine("Ingrese \"FIN\" como TITULO para terminar");
                    string tituloAPrestar;
                    do
                    {
                        Console.Write("Ingrese el TITULO del libro a prestar: ");
                        tituloAPrestar = Console.ReadLine().ToUpper();
                        if (tituloAPrestar != "FIN")
                        {
                            Console.Write("Ingrese el DNI del lector que solicita el libro: ");
                            int dniSolicitante = int.Parse(Console.ReadLine());

                            biblioteca.prestarLibro(tituloAPrestar, dniSolicitante);
                            
                        }
                    } while (tituloAPrestar != "FIN");
                    break;


            }
        }
    }
}



           
