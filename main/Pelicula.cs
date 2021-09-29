using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HerYPol
{
    class Pelicula:Multimedia
    {
        protected string ActorP;
        protected string ActrizP;

        public Pelicula(string T, string A, string F, tiempo D, string APH, string APM) : base(T, A, F, D)
        {
            this.ActorP = APH;
            this.ActrizP = APM;
        }

        /*
        public string getActorP()
        {
            return ActorP;
        }

        public string getActrizP()
        {
            return ActrizP;
        }

        public void setActorP(string A1)
        {
            this.ActorP = A1;
        }

        public void setActrizP(string A2)
        {
            this.ActrizP = A2;
        }

        */

        public override string ACadena()
        {
            return base.ACadena()+" || "+"Actor Principal: "+ActorP+" || "+"Actriz Principal: "+ActrizP;
        }
    }
}
