namespace AbstractFactoryDesignPattern.Factories
{
    using AbstractFactory;
    using Domain.Base;
    using Domain.Entities;

    public sealed class GuitarraFactory : InstrumentoCordaAbstractFactory
    {
        public override InstrumentoCordaBase CriaInstrumento(string modelo)
        {
            return new Guitarra(modelo);
        }
    }
}