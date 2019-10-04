namespace AbstractFactoryDesignPattern.Factories
{
    using System;
    using AbstractFactory;
    using Domain.Base;
    using Domain.Entities;
    using Domain.ValueObj;
    using FactoryMethod;

    public sealed class GuitarraFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            var guitarraType = (GuitarraType) instrumentoFactoryType;

            switch (guitarraType)
            {
                case GuitarraType.IbanezGRG250:
                {
                    return new GuitarraIbanezGRG250();
                }

                case GuitarraType.JacksonJ22:
                {
                    return new GuitarraJacksonJ22();
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}