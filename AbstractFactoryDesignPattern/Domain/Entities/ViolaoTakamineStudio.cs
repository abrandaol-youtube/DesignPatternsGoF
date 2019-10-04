using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    using Base;

    public sealed class ViolaoTakamineStudio : Violao
    {
        public ViolaoTakamineStudio() : base("TakamineStudio", 6)
        {
        }
    }
}
