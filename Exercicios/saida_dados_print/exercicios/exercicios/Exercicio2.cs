using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Exercicio2
    {

        public void Calc2()
        {
            int numb = Convert.ToInt32(Console.ReadLine());
            int numb2 = Convert.ToInt32(Console.ReadLine());
            int somar  = numb + numb2;
            int sub = numb - numb2;
            Console.WriteLine($"A soma dos dois numeros é: {somar}");
            Console.WriteLine($" subtracao dos do numeros é: {sub}");
           
        }
    }
}
