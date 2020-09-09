using Figuras.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras.Entidades
{
    class Circulo : Shape
    {
        public  double  Raio { get; set; }

        public Circulo(double raio, Cor cor) : base(cor) 
        {
            Raio = raio;
        }

        public override double Area()
        {
            return Math.PI * Raio * Raio;
        }
    }
}
