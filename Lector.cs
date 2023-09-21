using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace proyectoSemana7_biblioteca
{ 
    internal class Lector 
    {
          private List<Libro> librosRetirados;
          private string nombreLector, dni;
          
          public Lector(string nombreLector, string dni)
          {
              this.nombreLector = nombreLector;
              this.dni=dni;
              this.librosRetirados = new List<Libro>();
          }
          
          public string getNombreLector()
          {
              return nombreLector;
          }
          public int getDniLector()
          {
              return dni;
          }
          
          public List<Libro> getLibrosRetirados()
          {
              return librosRetirados;
          }

        public void agregarLibroARetirados(Libro libroRetirado)
        {
            librosRetirados.Add(libroRetirado);
        }

        public void eliminarLibroDeRetirados(Libro libroRetirado)
        {
            librosRetirados.Remove(libroRetirado);
        }
        
        public void listarLibros()
        {
            foreach (Libro libroRetirado in librosRetirados)
            {
                Console.WriteLine(libroRetirado);
            }
        }
                
    }



