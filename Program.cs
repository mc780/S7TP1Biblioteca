using System;
using System.Collections.Generic;
using System.Runtime.CompilerServices;

namespace proyectoSemana7_biblioteca
{
    class Test
    {
        public void Main(string[] args)
        {
            Biblioteca biblioteca = new Biblioteca();

            biblioteca.agregarLibro("El Quijote", "Miguel de Cervantes", "Alfaguara");
            biblioteca.agregarLibro("La Divina Comedia", "Dante Alighieri", "Planeta");
            biblioteca.agregarLibro("Hamlet", "William Shakespeare", "Alianza Editorial");

            cargarLibros(10);
            cargarLibros(2);
            biblioteca.listarLibros();

            //biblioteca.eliminarLibro("libro5");
            biblioteca.listarLibros();

            Lector lector = new Lector();
            lector.AltaLector("marcos", 33333333);
            lector.AltaLector("sandra", 44444444);
            lector.AltaLector("maria", 55555555);
            lector.AltaLector("roberto", 66666666);
            lector.AltaLector("marcos", 33333333);

            biblioteca.prestarLibro("El Quijote", 33333333);

            void cargarLibros(int cantidad)
            {
                bool pude;
                for (int i = 1; i <= cantidad; i++)
                {
                    pude = biblioteca.agregarLibro("Libro" + i, "Autor" + i, "Editorial" + i);
                    if (pude)
                    {
                        Console.WriteLine("libro" + i + " agregado correctamente");

                    }
                    else
                    {
                        Console.WriteLine("libro" + i + " Ya existe en la biblioteca");
                    }
                }
            }
        }         
    }
}



           
