namespace BuilderDesignPattern.Builders.Base
{
    using Domain;
    using Domain.ValueObject;

    public interface IPizzaBuilder
    {
        void PrepraraBorda(Borda borda);

        void PreparaMassa(PizzaSize pizzaSize);

        void InsereIngradientes();

        void DefineValor();

        void TempoForno();

        Pizza GetPizza();
    }
}