using ProjetoAbstract.Entites.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoAbstract.Entites
{
    internal class Retangulo : Figura
    {
        public double Altura { get; set; }
        public double Largura { get; set; }

        public Retangulo()
        {

        }

        public Retangulo(EnumColor color, double altura, double largura)
            : base(color)
        {
            Altura = altura;
            Largura = largura;
        }
        public override double Area()
        {
            return Altura * Largura;
        }
    }
}
