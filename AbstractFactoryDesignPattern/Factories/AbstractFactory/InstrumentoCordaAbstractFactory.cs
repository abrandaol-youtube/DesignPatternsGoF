using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Factories.AbstractFactory
{
    using Domain.Interface;

    public abstract class InstrumentoCordaAbstractFactory
    {
        protected abstract IInstrumentoCorda CriaInstrumento();
    }
}
