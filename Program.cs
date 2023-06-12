using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade02_Leitura
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nome;
            string produto1;
            string produto2;
            int qproduto1;
            int qproduto2;

            Console.WriteLine("Bem-Vindo ao sistema de estoque do Conrado Goodman \n");
            Console.WriteLine("Digite o nome do Funcionário responsável:");
            nome =  Console.ReadLine();

            Console.WriteLine($"\nO estoque será feito em nome de {nome}.\n");

            Console.WriteLine("-- Cadastro de Produtos\n");
            Console.WriteLine("Digite o NOME do Produto 1:");
            produto1 = Console.ReadLine();
            Console.WriteLine($"Digite a QUANTIDADE em estoque do item {produto1}");
            qproduto1 = Int32.Parse(Console.ReadLine());
            Console.WriteLine("\nDigite o NOME do Produto 2:");
            produto2 = Console.ReadLine();
            Console.WriteLine($"Digite a QUANTIDADE em estoque do item {produto2}");
            qproduto2 = Int32.Parse(Console.ReadLine());

            Console.WriteLine("\nOs produtos foram cadastrados com sucesso!");
            Console.WriteLine($"-- LISTA DE PRODUTOS CADASTRADOS POR {nome}\n");
            Console.WriteLine($"- {produto1} contém {qproduto1} itens em estoque.\n");
            Console.WriteLine($"- {produto2} contém {qproduto2} itens em estoque.\n");
            Console.WriteLine($"\n- Total de produtos em estoque: {qproduto1 + qproduto2}");

            Console.WriteLine($" \n------ FIM DO SISTEMA -----");

            Console.ReadKey();
        }
    }
}
