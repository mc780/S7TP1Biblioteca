using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Biblioteca
    {
        private List<Libro> libros;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
        }

        private Libro buscarLibro(string titulo)
        {
            Libro libroBuscado = null;
            int i = 0;
            while (i < libros.Count && !libros[i].getTitulo().Equals(titulo))
            {
                i++;
            }
            if (i != libros.Count)
            {
                libroBuscado = libros[i];
            }
            return libroBuscado; // Agregar esta línea para manejar el caso en que no se encuentra el libro
        }

        public bool agregarLibro(string titulo, string autor, string editorial)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro == null)
            {
                libro = new Libro(titulo, autor, editorial);
                libros.Add(libro);
                resultado = true;
            }
            return resultado;
        }

        public void listarLibros()
        {
            foreach (Libro libro in libros)
            {
                Console.WriteLine(libro);
            }
        }

        public bool eliminarLibro(string titulo)
        {
            bool resultado = false;
            Libro libro;
            libro = buscarLibro(titulo);
            if (libro != null)
            {
                libros.Remove(libro);
                resultado = true;
            }
            return resultado;
        }
        
/* Desarrollar el método prestarLibro de la clase Biblioteca la cual recibe por parámetro el título de un libro y el dni del lector que lo solicita 
    y retorna un string con los posibles valores:
"PRESTAMO EXITOSO" (en este caso el libro se le pudo prestar al lector, se lo quitó de la lista de libros que dispone la biblioteca 
y se lo adjudicó al lector).
"LIBRO INEXISTENTE" (cuando el libro no se encuentra dentro de la colección de libros en la biblioteca)
"TOPE DE PRESTAMO ALCAZADO" (cuando el lector ya posee tres libros en préstamo)
"LECTOR INEXISTENTE" (cuando el lector no es se encuentra registrado dentro de la colección de lectores en la biblioteca)
    */
        public prestarLibro(string titulo, int dni)
        {

            if (titulo != null && dni != null)
            {
                //libro existente
                Console.WriteLine("LIBRO EXISTENTE");
                Console.WriteLine("LECTOR EXISTENTE");
                if (prestamo < 3)
                {
                    //prestamo exitoso. en este caso el libro se le pudo prestar al lector, se lo quitó de la lista de libros que dispone la biblioteca y se lo adjudicó al lector
                    prestamo += 1;
                    Console.WriteLine("prestamo exitoso.");
                }
                else
                {
                    //tope de prestamo            
                }
            }
            else
            {
                Console.WriteLine("LIBRO INEXISTENTE");
                Console.WriteLine("LECTOR INEXISTENTE");
            }


        }
    /*Consigna Nº 2 : Desarrollar el método altaLector que pasándole los parámetros necesarios de el alta a un lector dentro de la lista de lectores si es que no se encontraba previamente registrado.

                Se propone hacer un ejercicio similar al propuesto por la teoría y crear dos métodos: el altaLector, requerido, y uno previo buscarLector que busque, mediante el ingreso por parámetro del DNI del lector a dar de alta, si el mismo se halla requerido o no (se busca solo por DNI ya que a efectos practicos es un identificador único, es decir, puede haber dos personas con el mismo nombre y apellido pero no con el mismo DNI).

                Previo a la codificación de los métodos, apliqué las siguientes modificaciones:

                Sobre la clase BIBLIOTECA:
                Agregué el arreglo List de lectores como variable y lo inicié en el constructor.*/
    
        private List<Lector> lectoresRegistrados;

        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectoresRegistrados = new List<Lector>();
        }

        }
}
