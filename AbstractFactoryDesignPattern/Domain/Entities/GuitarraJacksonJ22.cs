using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    using Base;

    public sealed class GuitarraJacksonJ22 : Guitarra
    {
        public GuitarraJacksonJ22() : base("Jackson J22", 6)
        {
        }
    }
}
