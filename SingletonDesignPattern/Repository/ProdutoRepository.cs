using System.Collections.Generic;
using SingletonDesignPattern.Domain;

namespace SingletonDesignPattern.Repository
{
    /*
     * Singleton
     *
     * Este padrão garante a existência de apenas uma instância de uma classe(um objeto em memória),
     *  mantendo um ponto global de acesso ao seu objeto.
     */
    public sealed class ProdutoRepository
    {
        private readonly IList<Produto> _produtos;
        private static ProdutoRepository _instance = null;
        private static readonly object SyncObj = new object();

        private ProdutoRepository()
        {
            _produtos = new List<Produto>();
        }

        public static ProdutoRepository GetInstance()
        {
            if (_instance != null) return _instance;

            lock (SyncObj)
            {
                if (_instance == null)
                {
                    _instance = new ProdutoRepository();
                }
            }

            return _instance;
        }

        public IList<Produto> GetAll()
        {
            return _instance._produtos;
        }

        public void Insert(Produto produto)
        {
            _instance._produtos.Add(produto);
        }
    }
}
