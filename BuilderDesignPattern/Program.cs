using System;

namespace BuilderDesignPattern
{
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
            Console.WriteLine("Hello nerds!");
        }
    }
}
