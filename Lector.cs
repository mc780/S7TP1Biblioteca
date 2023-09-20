using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
     /*   Sobre la clase LECTOR: Agregué el constructor para inicializar las variables y borré la lista de lectores, que dentro de la propia clase me parece que no tenía sentido.También agregué los metodos getNombreLector() y getDniLector() para usar en los metodos a desarrollar.
    También agregué la lista vacia librosRetirados para ser editada por la clase biblioteca cuando se confirmen prestamos (esto es tentativo, a confirmar que ande bien cuando se desarrolle el metodo prestar libro)
     */
    internal class Lector
        {
            private List<Libro> librosRetirados;
            private string nombreLector;
            private int dni;

            public Lector(string nombreLector, int dni)
            {
                this.nombreLector = nombreLector;
                this.dni = dni;
            }

            public string getNombreLector()
            {
                return nombreLector;
            }
            public int getDniLector()
            {
                return dni;
            }
        }

    /* Finalmente, los métodos altaLector, requerido, y el previo buscarLector quedaron asi: 
        Metodo buscarLector(no requerido, se codificó para usarlo en el que si se pide)*/

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

       // Metodo AltaLector(método requerido,)

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




