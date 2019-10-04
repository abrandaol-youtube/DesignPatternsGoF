namespace AbstractFactoryDesignPattern.Factories.FactoryMethod
{
    using System;
    using Domain.Base;

    public interface IInstrumentoFactoryMethod
    {
        InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType);
    }
}
