using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RegisztracioAlkalmazas_Babusane
{
    class Hobbik
    {
        string hobbi;

        public string Hobbi { get => hobbi; set => hobbi = value; }

        public Hobbik(string hobbi)
        {
            Hobbi = hobbi;
        }
    }
}
