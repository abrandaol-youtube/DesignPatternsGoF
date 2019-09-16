using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Builders
{
    using Base;
    using Domain;
    using Domain.ValueObject;
    using Processors;

    public sealed class PizzaModaCasa : PizzaBuilderBase, IPizzaBuilder
    {
        public PizzaModaCasa(ICalculaValor calculaValor) : base(calculaValor)
        {
        }

        public void PrepraraBorda(Borda borda)
        {
            throw new NotImplementedException();
        }

        public void PreparaMassaSemBorda(PizzaSize pizzaSize)
        {
            throw new NotImplementedException();
        }

        public void PreparaMassa(PizzaSize pizzaSize, Borda borda = null)
        {
            throw new NotImplementedException();
        }

        public void InsereIngradientes()
        {
            this.Pizza.IngredientesType =
                IngredientesType.Alho |
                IngredientesType.Calabresa |
                IngredientesType.Cebola |
                IngredientesType.Mussarela |
                IngredientesType.Provolone |
                IngredientesType.Pimentao |
                IngredientesType.Majericao |
                IngredientesType.Cheddar |
                IngredientesType.Catupiry;
        }

        public void TempoForno()
        {
            this.Pizza.TempoFornoMin = 28;
        }
    }
}
