using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1
{
    class aluno
    {
        private string Nome;
        private int matricula;
        private double[] nota;
        public double MédiaNotas(double[] notas)
        {
            double soma = 0;
            for(int i = 0; i < 50; i++)
            {
                soma += nota[i];
            }
            double media = soma / 50;
            return media;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {

        }
    }
}
