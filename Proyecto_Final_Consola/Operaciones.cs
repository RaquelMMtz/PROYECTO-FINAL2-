using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Final_Consola
{
    class Operaciones
    {
        double x, y;
        public Operaciones (double x, double y)
        {
            this.x = x;
            this.y = y;
        }
        public double opsuma()
        {
            return x + y;
        }
        public double opresta()
        {
            return x - y;
        }
        public double opmultiplicar()
        {
            return x + y;
        }
        public double opdividir()
        {
            return x / y;
        }
    }
}
