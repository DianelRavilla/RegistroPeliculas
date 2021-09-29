using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerYPol
{
    public class tiempo
    {

        string hora;
        string min;
        string sec;

        public tiempo(string h, string m, string s)
        {
            this.hora = h;
            this.min = m;
            this.sec = s;
        }

        /*
         
        public void setHora(string h)
        {
            this.hora = h;
        }

        public void setMinuto(string m)
        {
            this.min = m;
        }

        public void setSegundos(string s)
        {
            this.sec = s;
        }

        public string getHora()
        {
            return hora;
        }

        public string getMinutos()
        {
            return min;
        }

        public string getSegundos()
        {
            return sec;
        }

       */

        public string getDatos()
        {
            return hora + ":" + min+ ":" + sec;
        }

    }
}
