using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perro
{
    class Perro

    {
        public enum TIPOSDECOMIDA { CROQUETAS, BASURA, AGUA };

        static void Main(string[] args)
        {
            bool alimentado = false;
            Mascota Perro1 = new Mascota();

                Perro1.Raza = "French Puddle";
                Perro1.peso = 7;
                Perro1.Sexo = "Macho";
                Perro1.Tamaño = "Pequeña";

           alimentado = Perro1.Comer((int)TIPOSDECOMIDA.BASURA);
            if (alimentado)
            {
                Console.WriteLine("el perro" + Perro1.Raza + "comio" + Convert.ToString(TIPOSDECOMIDA.BASURA));
            }
            else
            {
                Console.WriteLine("el perro no ha sido alimentado");
            }

            Console.Read();

            Mascota Perro2 = new Mascota();
            Console.WriteLine("el perro" + Perro2.Raza + "comio" + Convert.ToString(TIPOSDECOMIDA.BASURA));
            Console.Read();

            Mascota Perro3 = new Mascota("XD", 15, "hembra","pequeño");
            Console.WriteLine("el perro" + Perro3.Raza + "comio" + Convert.ToString(TIPOSDECOMIDA.BASURA));
            Console.Read();

        }
    }
}

