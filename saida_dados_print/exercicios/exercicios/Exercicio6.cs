using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http.Headers;
using System.Text;
using System.Threading.Tasks;

namespace exercicios
{
    internal class Exercicio6
    {
        /*
Escrever um programa que leia o nome de um aluno e as notas das três provas que 
ele obteve no semestre. No final informar o nome do aluno e a sua média (aritmética). */
        public void  Calc6()
        {

    
            Console.WriteLine("1° bimestre  nota:");
            double primeiroBimestre = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("2° bimestre  nota:");
            double segundoBimestre =  Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("3° bimestre  nota:");
            double terceiroBimestre = Convert.ToDouble(Console.ReadLine());
                   Console.WriteLine("Nome do aluno:"); ;
            string? nomeAluno = Convert.ToString(Console.ReadLine());
            double mediaAluno= (primeiroBimestre + segundoBimestre + terceiroBimestre) / 3;

            Console.WriteLine($"1° bimestre  nota: {primeiroBimestre}");
            Console.WriteLine($"2° bimestre  nota: {segundoBimestre}");
            Console.WriteLine($"3° bimestre  nota: {terceiroBimestre}");

            Console.WriteLine($"nome do aluno: {nomeAluno}: nota final do aluno :{mediaAluno}");




        }



    }
}
