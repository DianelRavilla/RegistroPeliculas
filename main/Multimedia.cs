using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerYPol
{
    class Multimedia
    {
        protected string Titulo;
        protected string Autor;
        protected string Formato;
        protected tiempo Duracion;

        public Multimedia(string T, string A, string F, tiempo d)
        {
            this.Titulo = T;
            this.Autor = A;
            this.Formato = F;
            this.Duracion = d;
        }

        /*
        
        public string getTitulo()
        {
            return Titulo;
        }

        public string getAutor()
        {
            return Autor;
        }

        public string getFormato()
        {
            return Formato;
        }

        public tiempo getDuracion()
        {
            return Duracion;
        }

        public void setTitulo(string Tit)
        {
            this.Titulo = Tit;
        }
        public void setAutor(string Aut)
        {
            this.Autor = Aut;
        }

        public void setFormato(string For)
        {
            this.Formato = For;
        }

        public void setDuracion(tiempo dur)
        {
            this.Duracion = dur;
        }

        */

        public virtual string ACadena()
        {
            return "Titulo: " + Titulo + " || " + "Autor: " + Autor + " || " + "Formato: " + Formato + " || " + "Duracion: " + Duracion.getDatos();
        }
    }
}
