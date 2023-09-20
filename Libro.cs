using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Colecciones
{
    class Libro
    {
        private string titulo;
        private string autor;
        private string editorial;

        public Libro(string titulo, string autor, string editorial)
        {
            this.titulo = titulo;
            this.autor = autor;
            this.editorial = editorial;
        }


        public string getTitulo()
        { return titulo; }

        public override string ToString()
        {
            return "Titulo" + titulo + "Autor: " + autor + "Editorial: " + editorial;
        }
    }
}
