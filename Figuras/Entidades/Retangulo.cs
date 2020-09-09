using Figuras.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Security.Principal;
using System.Text;

namespace Figuras.Entidades
{
    class Retangulo : Shape
    {
        public double Largura { get; set; }
        public double Altura { get; set; }

        public Retangulo(double largura, double altura, Cor cor) : base(cor) 
        {
            Largura = Largura;
            Altura = Altura;
        }

        public override double Area()
        {
            return Largura * Altura;
        }
    }
}
