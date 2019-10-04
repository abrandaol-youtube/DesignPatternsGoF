using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factories
{
    using AbstractFactory;
    using Domain.Base;
    using Domain.Entities;
    using Domain.Interface;

    public sealed class GuitarraFactory : InstrumentoCordaAbstractFactory
    {
        public override InstrumentoCordaBase CriaInstrumento(string modelo)
        {
            return new Guitarra(modelo);
        }
    }
}
