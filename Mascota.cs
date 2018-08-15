using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace perro
{
    class Mascota
    {
        public string Tamaño;
        public string Raza;
        public string Sexo;
        public int peso;
        public string Color;
        public enum TIPOSDECOMIDA { CROQUETAS, BASURA, AGUA };

        public Mascota()
        {
           Raza = "pitbull";
           peso = 8;
           Sexo = "Macho";
           Tamaño = "grande";
        }
        public Mascota(string raza, int Peso, string sexo, string tamaño)
        {
            Raza = raza;
            peso = Peso;
            Sexo = sexo;
            Tamaño = tamaño;
        }

        public void Ladrar()
        {

        }

        public void Correr()
        {

        }
        public bool Comer(int alimento)
        {
            bool resultado = false;
            if (alimento == (int)TIPOSDECOMIDA.AGUA)
            {
                resultado = false;
            }
            else if (alimento == (int)TIPOSDECOMIDA.BASURA)
            {
                resultado = true;
            }
            else if (alimento == (int)TIPOSDECOMIDA.CROQUETAS)
            {
                resultado = true;
            }
            return resultado;

        }
        public void Cagar()
        {

        }

    }
}
