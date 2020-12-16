using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Consola
{
    class Persona : Usuario
    {
        protected string edad;

        public string Edad
        {
            get { return edad; }
            set { edad = value; }
        }
    }
}
