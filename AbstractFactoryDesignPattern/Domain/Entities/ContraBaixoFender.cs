using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    using Base;

    public sealed class ContraBaixoFender : ContraBaixo
    {
        public ContraBaixoFender() : base("Fender", 4)
        {
        }
    }
}
