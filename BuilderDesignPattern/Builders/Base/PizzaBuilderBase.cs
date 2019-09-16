using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Builders.Base
{
    using Domain;
    using Processors;

    public abstract class PizzaBuilderBase
    {
        protected readonly Pizza Pizza;
        protected readonly ICalculaValor CalculaValor;
        protected PizzaBuilderBase(ICalculaValor calculaValor)
        {
            Pizza = new Pizza();
            CalculaValor = calculaValor;
        }

        public virtual void DefineValor()
        {
            CalculaValor.DefineValor(Pizza);
        }

        public Pizza GetPizza()
        {
            return Pizza;
        }
    }
}
