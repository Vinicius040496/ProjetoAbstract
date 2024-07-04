using ProjetoAbstract.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstract.Entites
{
    internal class Circulo : Figura
    {
        public double Raio {  get; set; }

        public Circulo()
        {

        }

        public Circulo(EnumColor color,double raio): base(color)
           
        {
            Raio = raio;
        }
        double Pi = 3.14;
        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
