using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ProjetoAbstract.Entites.Enums;

namespace ProjetoAbstract.Entites
{
    abstract class Figura
    {
        public EnumColor Color { get; set; }

        protected Figura()
        {

        }

        protected Figura(EnumColor color)
        {
            Color = color;
        }
        public abstract  double Area();
        
    }
}
