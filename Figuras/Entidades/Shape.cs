using Figuras.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Text;

namespace Figuras.Entidades
{
    abstract class Shape
    {
        public Cor Cor { get; set; }

        public Shape(Cor cor) 
        {
            Cor = cor;
        }

        public abstract double Area();
    }
}
