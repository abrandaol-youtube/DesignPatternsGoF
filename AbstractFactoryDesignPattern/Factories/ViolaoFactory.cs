namespace AbstractFactoryDesignPattern.Factories
{
    using System;
    using AbstractFactory;
    using Domain.Base;
    using Domain.Entities;
    using Domain.ValueObj;
    using FactoryMethod;

    public sealed class ViolaoFactory : IInstrumentoFactoryMethod
    {
        public InstrumentoCordaBase CriaInstrumento(Enum instrumentoFactoryType)
        {
            var violaoType = (ViolaoType)instrumentoFactoryType;

            switch (violaoType)
            {
                case ViolaoType.Takamine1ER4:
                {
                    return new ViolaoTakamine1ER4();
                }

                case ViolaoType.TakamineStudio:
                {
                    return new ViolaoTakamineStudio();
                }

                default:
                    throw new ArgumentOutOfRangeException();
            }
        }
    }
}