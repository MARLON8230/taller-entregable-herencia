using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace taller_final
{
   public class Miligramos : Convertir
    {
        public double miligramos()
        {
            return (this.getPeso() /0.0000010000);
        }
    }
}
