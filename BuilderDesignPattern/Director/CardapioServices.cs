using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Director
{
    using Builders.Base;
    using Domain;
    using Domain.ValueObject;

    public class CardapioServices
    {
        public void PrepararPizzaSemBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize)
        {
            pizzaBuilder.PreparaMassaSemBorda(pizzaSize);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }

        public void PrepararPizzaComBorda(IPizzaBuilder pizzaBuilder, PizzaSize pizzaSize, Borda borda)
        {
            pizzaBuilder.PreparaMassa(pizzaSize, borda);
            pizzaBuilder.InsereIngradientes();
            pizzaBuilder.TempoForno();
            pizzaBuilder.DefineValor();
        }
    }
}
