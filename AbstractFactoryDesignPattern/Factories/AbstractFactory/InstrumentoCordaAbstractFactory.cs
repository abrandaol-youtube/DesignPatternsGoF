using System;

namespace AbstractFactoryDesignPattern.Factories.AbstractFactory
{
    using Domain.Interface;
    using Domain.ValueObj;

    public abstract class InstrumentoCordaAbstractFactory
    {
        protected abstract IInstrumentoCorda CriaInstrumento();

        public static InstrumentoCordaAbstractFactory CriaFabrica(InstrumentoType instrumentoType)
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
