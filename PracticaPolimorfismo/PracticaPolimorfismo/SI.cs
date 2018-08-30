using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
     class SI:Sensor
    {
        public SI()
        {
            this.d = 0;
        }
        public SI(int D)
        {
            this.d = D;
        }
        public override string A()
        {
            if (5 < this.d)
            {
                return "avanza";
            }
            else
            {
                return "detenerse";
            }


        }
        
    }
}
