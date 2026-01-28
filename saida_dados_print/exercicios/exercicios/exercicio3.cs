using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class exercicio3
    {

        public void calc3()
        {
            double Base = Convert.ToSingle(Console.ReadLine());
            double Altura = Convert.ToSingle(Console.ReadLine());
            double area = (Base * Altura);
            Console.WriteLine($"A area do retangulo e: `{area}");

       
        }
    }
}
