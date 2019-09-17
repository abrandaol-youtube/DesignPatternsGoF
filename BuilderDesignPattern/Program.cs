using System;

namespace BuilderDesignPattern
{
    using Builders;
    using Builders.Base;
    using Director;
    using Domain;
    using Domain.ValueObject;
    using Processors;

    /*
        Intenção

            - "Separar a construção de um obejto complexo de sua representação de modo que
                o processo de construção possa criar diferentes representações".

        Vantagens do padrão Builder

        - O padrão builder permite ao desenvolvedor esconder detalhes de como os objetos são criados
        - O padrão Builder permite ao desenvolvedor um grande variedade de repsoentações internas do objeto a ser construído
        - Cada Builder é independente de outros e do restante da aplicação
            - provê modularidade
            - simplifica a adição no novos Builders
        - Provê grande controle sobre a criação de objetos complexos
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            var calcValor = new CalculaValor();

            IPizzaBuilder pizzaCalabresaBuilder = new PizzaCalabresa(calcValor);
            IPizzaBuilder pizzaModaCasaBuilder = new PizzaModaCasa(calcValor);

            var cardapioService = new CardapioServices();

            #region Pizza 1

            cardapioService.PrepararPizzaComBorda(pizzaCalabresaBuilder,
                PizzaSize.Grande, new Borda { BordaType = BordaType.Catupiry, BordaSize = BordaSize.Normal });

            var pizzacalabresa1 = pizzaCalabresaBuilder.GetPizza();

            #endregion Pizza 1

            #region Pizza 2

            cardapioService.PrepararPizzaSemBorda(pizzaCalabresaBuilder, PizzaSize.Grande);

            var pizzacalabresa2 = pizzaCalabresaBuilder.GetPizza();

            #endregion Pizza 2

            #region Pizza 3

            cardapioService.PrepararPizzaComBorda(pizzaModaCasaBuilder,
                PizzaSize.Grande, new Borda { BordaType = BordaType.Catupiry, BordaSize = BordaSize.Normal });

            var pizzaModaCasa1 = pizzaModaCasaBuilder.GetPizza();

            #endregion Pizza 3

            View("Pizza 1: ", pizzacalabresa1);
            View("Pizza 2: ", pizzacalabresa2);
            View("Pizza 3: ", pizzaModaCasa1);
        }

        public static void View(string msg, Pizza pizza)
        {
            Console.WriteLine($"{pizza.Sabor} / {pizza.Valor:C} / {pizza.TempoFornoMin} min / {pizza.PizzaSize.ToString()}");
        }
    }
}