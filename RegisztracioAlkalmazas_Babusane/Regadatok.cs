using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas_Babusane
{
    class Regadatok
    {
        string nev;
        DateTime szuldatum;
        string nem;
        string hobbi;


        public string Nev { get => nev; set => nev = value; }
         public DateTime Szuldatum { get => szuldatum; set => szuldatum = value; }
        public string Nem { get => nem; set => nem = value; }
        //public DateTime Szuldatum
        //{
        //    set
        //    {
        //        if (Szuldatum != DateTime.Today)
        //        {
        //            Szuldatum = value;
        //        }
        //    }
        //    get { return Szuldatum; }
        //}

        public string Hobbi { get => hobbi; set => hobbi = value; }

        public Regadatok(string nev, DateTime szuldatum, string nem, string hobbi)
        {
            Nev = nev;
            Szuldatum = szuldatum;
            Nem = nem;
            Hobbi = hobbi;
           
        }

        public override string ToString()
        {
            return nev + "; (Született: " + Szuldatum + "); "  + nem + "; " + hobbi;
        }


    }
}
