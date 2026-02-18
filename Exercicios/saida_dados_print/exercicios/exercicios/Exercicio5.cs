using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Exercicio5
    {
        /*Escrever um programa que leia o nome de um vendedor, o seu salário fixo e o total 
          de vendas efetuadas por ele no mês (em dinheiro). Sabendo que este vendedor ganha 
          15% de comissão sobre suas vendas efetuadas, informar o seu nome, o salário fixo e 
          salário no final do mês.*/
    public void Calc5()
        {
             float constporcentagem = 0.15f;
            Console.WriteLine("Informe o nome do vendor ");
            string ?nomeVendedor = Console.ReadLine();
            Console.WriteLine("Informe o salario fixo");
            double salarioFixo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Informe o total de vendas efetuadas no mês");
            int totalVendas = Convert.ToInt32(Console.ReadLine());

            double SalarioMensal =  salarioFixo;
            int quantidadevendas = totalVendas;
            double comissao = SalarioMensal + (quantidadevendas * constporcentagem);
            double salarioFinal = SalarioMensal + comissao;

            Console.WriteLine($" O nome do Vendedor é: {nomeVendedor} ");
            Console.WriteLine($" Salário fixo é de : R${salarioFixo}  ");
            Console.WriteLine($" Total de vendas efetuadas no mês é de : {quantidadevendas} ");
            Console.WriteLine($" Comissão sobre as vendas é de :R$ {comissao} ");
            Console.WriteLine($" Salário final do mês é de :R$ {salarioFinal} ");



        }
    }
}
