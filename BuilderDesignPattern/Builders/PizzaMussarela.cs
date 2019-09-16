using System;

namespace BuilderDesignPattern.Builders
{
    using Base;
    using Domain;
    using Domain.ValueObject;
    using Processors;

    public sealed class PizzaMussarela : PizzaBuilderBase, IPizzaBuilder
    {
        public PizzaMussarela(ICalculaValor calculaValor) : base(calculaValor)
        {
        }

        public void PrepraraBorda(Borda borda)
        {
            throw new Exception("Não é possivel colocar borda na pizza de mussarela");
        }

        public void PreparaMassa(PizzaSize pizzaSize, Borda borda = null)
        {
            if(borda != null) throw new Exception("Não é possivel colocar borda na pizza de mussarela");
        }

        public void PreparaMassaSemBorda(PizzaSize pizzaSize)
        {
            this.Pizza.PizzaSize = pizzaSize;
        }

        public void InsereIngradientes()
        {
            this.Pizza.IngredientesType =
                IngredientesType.Mussarela |
                IngredientesType.Tomate;
        }

        public void TempoForno()
        {
            this.Pizza.TempoFornoMin = 12;
        }
    }
}
