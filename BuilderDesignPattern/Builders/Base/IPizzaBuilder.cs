namespace BuilderDesignPattern.Builders.Base
{
    using Domain;
    using Domain.ValueObject;

    public interface IPizzaBuilder
    {
        void PrepraraBorda(Borda borda);
        void PreparaMass(PizzaSize pizzaSize, Borda borda = null);
        void InsereIngradientes();
        void DefineValor();
        void TempoForno();
        void PreparaMassSemBorda(PizzaSize pizzaSize);
    }
}
