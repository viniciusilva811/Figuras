using Figuras.Entidades;
using Figuras.Entidades.Enum;
using System;
using System.Collections.Generic;
using System.Globalization;

namespace Figuras
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Shape> list = new List<Shape>();

            Console.WriteLine("Entre com a quantidade de figuras: ");
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++) 
            {
                Console.WriteLine($"Figura #{i} ");
                Console.Write("Retangulo ou circulo: ");
                char ch = char.Parse(Console.ReadLine());
                Console.Write("Color (Black/Blue/Red): ");
                Cor cor = Enum.Parse<Cor>(Console.ReadLine());

                if (ch == 'r')
                {
                    Console.Write("Largura: ");
                    double largura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

                    Console.Write("Altura: ");
                    double altura = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);


                    list.Add(new Retangulo(largura, altura, cor));
                }

                else 
                {
                    Console.Write("Raio: ");
                    double raio = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                    list.Add(new Circulo(raio, cor));
                }

                
            }
            Console.WriteLine();
            Console.WriteLine("Area da figura: ");
            foreach (Shape shape in list)
            {
                Console.WriteLine(shape.Area().ToString("F2", CultureInfo.InvariantCulture));
            }
        }
    }
}
