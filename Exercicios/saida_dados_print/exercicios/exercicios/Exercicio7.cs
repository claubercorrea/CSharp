using Execercicos;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Exercicio7
    {

        public void Calc7()
        {
            /*Faça um programa que: 
            a) Obtenha o valor para a variável HT(horas trabalhadas no mês);
            b) Obtenha o valor para a variável VH(valor hora trabalhada): 
            c) Obtenha o valor para a variável PD(percentual de desconto);
            d) Calcule o salário bruto => SB = HT * VH;
            e) Calcule o total de desconto => TD = (PD / 100) * SB;
            f) Calcule o salário líquido => SL = SB – TD;
            g) Apresente os valores de: Horas trabalhadas, Salário Bruto, Desconto, Salário
            Liquido*/
            Console.WriteLine("horas trabalhadas");

            int horas = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Valor das horas trabalhadas");

            double valorHoras = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Percentual de descontos");
            double percentualDesconto = Convert.ToDouble(Console.ReadLine());
            
            double salarioBruto = horas * valorHoras;
            double totalDescontos = (percentualDesconto / 100) * salarioBruto;
            double salarioLiquido = salarioBruto - totalDescontos;

            Console.WriteLine($" Valor do salario bruto {salarioBruto}");

            Console.WriteLine($"total de desconto: {totalDescontos}");
            Console.WriteLine($"o salario liquido do funcionario: {salarioLiquido}");

        
        }

    }
}
