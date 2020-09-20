using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace taller_final
{
    public class Calculos
    {
        private double numero1, numero2;
        public void setNumero1(double valor)
        {
            this.numero1 = valor;

        }
        public void setNumero2(double valor)
        {
            this.numero2 = valor;

        }
        public double getNumero1()
        {
            return this.numero1;
        }
        public double getNumero2()
        {
            return this.numero2;
        }
    }
}