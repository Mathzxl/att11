using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2
{
    class Triângulo
    {
        public double lado1;
        public double lado2;
        public double lado3;
        public Triângulo(double lado1, double lado2, double lado3)
        {
            this.lado1 = lado1;
            this.lado2 = lado2;
            this.lado3 = lado3;
        }
        public Triângulo()
        {
            this.lado1 = 1.4;
            this.lado2 = 5.6;
            this.lado3 = 5.4;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            double lado1,lado2,lado3;
            Console.WriteLine("Dê o lado do triângulo");
            lado1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dê o lado do triângulo");
            lado2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Dê o lado do triângulo");
            lado3 = double.Parse(Console.ReadLine());
            Triângulo triângulo = new Triângulo(lado1, lado2, lado3);
            Console.WriteLine("\n" + triângulo.lado1);
            Console.WriteLine(triângulo.lado2);
            Console.WriteLine(triângulo.lado3);
            Triângulo trg = new Triângulo();
            Console.WriteLine("\n" + trg.lado1);
            Console.WriteLine(trg.lado2);
            Console.WriteLine(trg.lado3);
            Console.ReadLine();
        }
    }
}
