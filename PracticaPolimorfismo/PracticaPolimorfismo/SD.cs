using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    class SD:Sensor
    {
        public SD()
        {
            this.d = 0;
        }
        public SD(int D)
        {
            this.d = D;
        }
        public override string A()
        { 
            if(100 > this.d  )
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
