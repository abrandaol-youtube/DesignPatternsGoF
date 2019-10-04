namespace AbstractFactoryDesignPattern.Factories
{
    using System;
    using AbstractFactory;
    using Domain.Base;
    using Domain.Entities;
    using Domain.ValueObj;
    using FactoryMethod;

    public sealed class ContraBaixoFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            var contraBaixoType = (ContraBaixoType)instrumentoFactoryType;

            switch (contraBaixoType)
            {
                case ContraBaixoType.Fender:
                {
                    return new ContraBaixoFender();
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}