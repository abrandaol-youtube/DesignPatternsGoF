namespace BuilderDesignPattern.Director
{
    using Builders.Base;
    using Domain;
    using Domain.ValueObject;

    public class CardapioServices
    {
        public void PrepararPizzaSemBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }

        public void PrepararPizzaComBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize, Borda borda)
        {
            pizzaBuilder.PreparaMassa(pizzaSize);
            pizzaBuilder.PrepraraBorda(borda);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }
    }
}