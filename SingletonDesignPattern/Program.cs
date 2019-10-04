using System;
using SingletonDesignPattern.Domain;
using SingletonDesignPattern.Repository;

namespace SingletonDesignPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var repo = ProdutoRepository.GetInstance();

            var lista1 = repo.GetAll();

            repo.Insert(new Produto{ Id = 1, Name = "AAA", Price = 12 });
            repo.Insert(new Produto { Id = 2, Name = "BBBB", Price = 33 });

            var lista2 = repo.GetAll();

            var repo2 = ProdutoRepository.GetInstance();

            var lista3 = repo2.GetAll();

            Console.WriteLine("Hello .nerds!");
        }
    }
}
