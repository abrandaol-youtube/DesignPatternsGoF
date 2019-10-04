namespace AbstractFactoryDesignPattern.Factories
{
    using AbstractFactory;
    using Domain.Base;
    using Domain.Entities;

    public sealed class ContraBaixoFactory : InstrumentoCordaAbstractFactory
    {
        public override InstrumentoCordaBase CriaInstrumento(string modelo)
        {
            return new ContraBaixo(modelo);
        }
    }
}