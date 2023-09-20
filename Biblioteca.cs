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
        
        
        
        /* Consigna Nº2 - Método 'altaLector'. Se le pasan los parámetros necesarios y realiza
           el alta a un lector sólo si este no se encuentra dentro de la lista de lectores
           previamente registrados, para buscarlo se crea previamente el método 'buscarLector'
           que busca al lector por su DNI, considerando que este es un identificador único
           para cualquuier persona.
           Mediante un valor de tipo Bool informa si el alta fue exitosa (true) o no (false)."*/
        private Lector buscarLector(int dniLector)
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
        
        public bool AltaLector(string nomNuevLector, int dniNuevLector)
        {
            bool resultadoAlta = false;
        
            Lector nuevoLector;
        
            nuevoLector = buscarLector(dniNuevLector);
        
            if (nuevoLector == null)
            {
                nuevoLector = new Lector(nomNuevLector, dniNuevLector);
                lectoresRegistrados.Add(nuevoLector);
                resultadoAlta = true;
            }
            return resultadoAlta;
}
}
