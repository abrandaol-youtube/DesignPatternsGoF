using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factories
{
    using AbstractFactory;
    using Domain.Entities;
    using Domain.Interface;

    public sealed class ViolaoFactory : InstrumentoCordaAbstractFactory
    {
        protected override IInstrumentoCorda CriaInstrumento()
        {
            return new Violao();
        }
    }
}
