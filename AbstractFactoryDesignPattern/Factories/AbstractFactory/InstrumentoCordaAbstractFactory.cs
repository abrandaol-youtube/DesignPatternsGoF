using System;

namespace AbstractFactoryDesignPattern.Factories.AbstractFactory
{
    using Domain.Base;
    using Domain.Interface;
    using Domain.ValueObj;

    public abstract class InstrumentoCordaAbstractFactory
    {
        public abstract InstrumentoCordaBase CriaInstrumento(string modelo);

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
