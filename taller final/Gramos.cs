using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;

namespace taller_final
{
   public class Gramos : Convertir
    {
        public double gramos()
        {
            return (this.getPeso() * 1000);
        }
            
    }
}
