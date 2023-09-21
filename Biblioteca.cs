using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana7_biblioteca
{
    class Biblioteca
    {
        private List<Libro> libros;
        private List<Lector> lectoresRegistrados;
        
        public Biblioteca()
        {
            this.libros = new List<Libro>();
            this.lectoresRegistrados = new List<Lector>();
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
            return libroBuscado;
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
        
        
        
        /* Consigna Nº2 - Método 'altaLector'. Se le pasan los parámetros necesarios y realiza
           el alta a un lector sólo si este no se encuentra dentro de la lista de lectores
           previamente registrados, para buscarlo se crea previamente el método 'buscarLector'
           que busca al lector por su DNI, considerando que este es un identificador único
           para cualquuier persona.
           Mediante un valor de tipo Bool informa si el alta fue exitosa (true) o no (false)."*/
        private Lector buscarLector(string dniLector)
        {
            Lector lectorBuscado = null;
            int i = 0;
            while (i < lectoresRegistrados.Count && !lectoresRegistrados[i].getDniLector().Equals(dniLector))
            {
                i++;
            }
            if (i != lectoresRegistrados.Count)
            {
                lectorBuscado = lectoresRegistrados[i];
            }
            return lectorBuscado; // Agregar esta línea para manejar el caso en que no se encuentra el libro
        }
        
        public bool AltaLector(string nomNuevLector, string dniNuevLector)
        {
            bool resultadoAlta = false;
            
            if (dniNuevLector.Length>=7 && dniNuevLector.Length <= 8)
            {
                Lector nuevoLector;
                nuevoLector = buscarLector(dniNuevLector);
            
                if (nuevoLector == null)
                {
                    nuevoLector = new Lector(nomNuevLector, dniNuevLector);
                    lectoresRegistrados.Add(nuevoLector);
                    resultadoAlta = true;
                }
            }
            return resultadoAlta;
        }


        public void prestarLibro(string titulo, string dni)
        {
             // Verificar si libro existe.
            Libro libroAPrestar = buscarLibro(titulo);
        
            // Verificar si lector existe.
            Lector lectorSolicitante = buscarLector(dni);
        
            
            // El libro no se encuentra dentro de la colección de libros en la biblioteca.
            if (libroAPrestar == null)
            {
                Console.WriteLine("LIBRO INEXISTENTE");
            }
            // El lector no es se encuentra registrado dentro de la colección de lectores en la biblioteca.
            else if (lectorSolicitante == null)
            {
                Console.WriteLine("LECTOR INEXISTENTE");
            }
            // El lector ya posee tres libros en préstamo.
            else if (lectorSolicitante != null && lectorSolicitante.getLibrosRetirados().Count >= 3)
            {
                Console.WriteLine("TOPE DE PRESTAMO ALCAZADO");
            }
            else
            {
                /* Se busca la posición de la lista de lectores en donde se halla
                   el lector que solicita el libro.*/
                int posicionLector = lectoresRegistrados.IndexOf(lectorSolicitante);
        
                /* Se agrega el libro a la lista de libros retirados de esa instancia de 
                   la clase Lector especifica mediante el método correspondiente.*/
                lectoresRegistrados[posicionLector].agregarLibroARetirados(libroAPrestar);
        
                /* Se elimina el libro del listado de libros en tenencia de la Biblioteca.*/
                eliminarLibro(titulo);
        
                /*Se comunica el éxito en la generación del préstamo*/
                Console.WriteLine("PRESTAMO EXITOSO");
            }

        }

    }

}
