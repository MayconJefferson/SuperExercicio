using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SuperExercício
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Dado que eu tenho uma escola de programação
            Faça um programa que capture o nome, a matricula e as notas (4 notas) dos alunos
            Os alunos serão aprovados com notas igual ou maior que 7
            A quantidade de alunos é dinamica, ou seja, o usuário do programa pode digitar quantos alunos ele quiser.
            Obs: temos que digitar os nomes, as matriculas as notas e o sistema calcular o resto
            No final do programa, mostre um relatório assim:

            Segue a lista dos alunos:
            ------------------------------------
            Nome: xxx
            Matrícula: yyyy
            Notas: 1,2,3,4
            Média: 5.6
            Status: Aprovado
            ------------------------------------ */

            Console.WriteLine("Quantos alunos serão cadastrados?");
            int qtdeCadastros = Convert.ToInt32(Console.ReadLine());

            List<dynamic> lista = new List<dynamic>();

            for (int i =0; i < qtdeCadastros; i++)
            {
                Console.Write("Nome: ");
                string nome = (Console.ReadLine());
                Console.Write("Matrícula: ");
                int matricula = Convert.ToInt32(Console.ReadLine());
                Console.Write("Primeira nota: ");
                double nota1 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Segunda nota: ");
                double nota2 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Terceira nota: ");
                double nota3 = Convert.ToDouble(Console.ReadLine());
                Console.Write("Quarta nota: ");
                double nota4 = Convert.ToDouble(Console.ReadLine());
                Console.Clear();

                double media = (nota1 + nota2 + nota3 + nota4) / 4;
                string Situaçao = media >= 7 ? "Aprovado" : "Reprovado";

                lista.Add(new
                {
                    Nome = nome,
                    Matricula = matricula,
                    Notas = new List<double>() { nota1, nota2, nota3, nota4},
                    Media = media,
                    Situaçao = Situaçao,
                });               
            }

            for (int i = 0; i< lista.Count; i++)
            {
                Console.WriteLine($"Nome: {lista[i].Nome}");
                Console.WriteLine($"Matricula: {lista[i].Matricula}");
                Console.WriteLine($"Notas: {string.Join(", ", lista[i].Notas.ToArray())}");
                Console.WriteLine($"Media: {lista[i].Media}");
                Console.WriteLine($"Situaçao: {lista[i].Situaçao}\n");
            }
            Console.ReadKey();
        }
    }
}
