using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerYPol
{
    class PeliculaDocumental:Pelicula
    {
        private string Categoria;
        public PeliculaDocumental(string T, string A, string F, tiempo D, string APH, string APM, string cat) : base(T, A, F, D, APH, APM)
        {
            this.Categoria = cat;
        }
      
        /*
        public string getCategoria()
        {
            return Categoria;
        }

        public void setCategoria(string Ctg)
        {
            this.Categoria = Ctg;
        }

        */

        public override string ACadena()
        {
            return base.ACadena() + " || " + "Categoria: " + Categoria;
        }
    }
}
