using System;
using System.Collections.Generic;
using System.Text;

namespace SingletonDesignPattern.Domain
{
    public sealed class Produto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public decimal Price { get; set; }
    }
}
