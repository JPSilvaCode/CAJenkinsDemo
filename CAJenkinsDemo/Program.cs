using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CAJenkinsDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            IList<Produto> produtos = new List<Produto>();

            var produto = new Produto();
            produto.Id = 1;
            produto.Nome = "Teste";

            produtos.Add(produto);

            Console.WriteLine("testes");
            Console.ReadKey();
        }
    }
}
