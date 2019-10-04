using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    using Base;

    public sealed class GuitarraIbanezGRG250 : Guitarra
    {
        public GuitarraIbanezGRG250() : base("GRG 250", 6)
        {
        }
    }
}
