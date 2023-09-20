using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{ 
    internal class Lector 
    {
          private List<Libro> librosRetirados;
          private string nombreLector;
          private int dni;
          
          public Lector(string nombreLector, int dni)
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
         
    }




