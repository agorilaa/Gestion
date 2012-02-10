using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace appGestion.BBL
{
    public class Oferser
    {
        private int codO;
        private int codS;

        public int CodO
        {
            get
            {
                return this.codO;
            }
            set
            {
                this.codO = value;
            }
        }
        public int CodS
        {
            get
            {
                return this.codS;
            }
            set
            {
                this.codS = value;
            }
        }
        //Méodos
        public Oferser(int vcodO, int vcodS) 
        {
            this.codO = vcodO;
            this.codS = vcodS;
        }
    }
}