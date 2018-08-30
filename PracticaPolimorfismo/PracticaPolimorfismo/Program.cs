using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPolimorfismo
{
    class Program
    {
        
        public static void Main(string[] args)
        {
            int op;
            int d;
            
            
            Console.WriteLine("introduce una opcion \n 1 avanzar\n 2 reversa");
            op = Convert.ToInt16(Console.ReadLine());
            if(op == 1)
            {
                //aqui va la llamada a mi clase sensor
                
                Console.WriteLine("introduce la distancia al objeto mas cercano");
                d = Convert.ToInt16(Console.ReadLine());
                SD S = new SD(d);
                Console.WriteLine( S.A());
                

                

            }
            else if( op == 2)
            {
                //aqui va la llamada a sensor
                Console.WriteLine("introduce la distancia al objeto mas cercano");
                d = Convert.ToInt16(Console.ReadLine());
                SI S = new SI(d);
                Console.WriteLine(S.A());
            }
            else
            {
                Console.WriteLine("opcion invalida");
                Console.ReadLine();
            }
            Console.ReadKey();     
        }
    }
}
