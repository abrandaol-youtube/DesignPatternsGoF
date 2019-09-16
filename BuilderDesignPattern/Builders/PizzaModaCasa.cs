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
            
        }

        public void PreparaMassaSemBorda(PizzaSize pizzaSize)
        {
            this.Init();
            this.Pizza.PizzaSize = pizzaSize;
        }

        public void PreparaMassa(PizzaSize pizzaSize, Borda borda = null)
        {
            this.Init();
            this.Pizza.Borda = borda;
            this.Pizza.PizzaSize = pizzaSize;
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
