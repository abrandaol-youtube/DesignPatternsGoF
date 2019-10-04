namespace AbstractFactoryDesignPattern.Factories
{
    using AbstractFactory;
    using Domain.Base;
    using Domain.Entities;

    public sealed class ViolaoFactory : InstrumentoCordaAbstractFactory
    {
        public override InstrumentoCordaBase CriaInstrumento(string modelo)
        {
            return new Violao(modelo);
        }
    }
}