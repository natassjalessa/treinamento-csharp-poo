using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace opNumericas
{
    public class Calculadora
    {
        public double n1 { get; set; }
        public double n2 { get; set; }
        public double res { get; set; }

        public Calculadora()
        {
            this.n1 = 0;
            this.n2 = 0;
            this.res = 0;
        }

        public void Somar()
        {
            res = n1 + n2;
        }

        public void Subtrair()
        {
            res = n1 - n2;
        }

        public void Multiplicar()
        {
            res = n1 * n2;
        }

        public void Dividir()
        {
            res = n1 / n2;
        }
    }
}
