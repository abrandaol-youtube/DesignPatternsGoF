using System;

namespace AbstractFactoryDesignPattern.Factories.AbstractFactory
{
    using Domain.Base;
    using Domain.ValueObj;
    using FactoryMethod;

    public abstract class InstrumentoCordaAbstractFactory
    {
        public static IInstrumentoFactoryMethod CriaFabrica(InstrumentoType instrumentoType)
        {
            switch (instrumentoType)
            {
                case InstrumentoType.Violao:
                    {
                        return new ViolaoFactory();
                    }
                case InstrumentoType.Guitarra:
                    {
                        return new GuitarraFactory();
                    }
                case InstrumentoType.ContraBaixo:
                    {
                        return new ContraBaixoFactory();
                    }

                default:
                    throw new ArgumentOutOfRangeException(nameof(instrumentoType), instrumentoType, null);
            }
        }
    }
}