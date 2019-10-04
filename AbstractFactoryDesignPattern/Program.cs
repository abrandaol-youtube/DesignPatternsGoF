using System;

namespace AbstractFactoryDesignPattern
{
    using Domain.Base;
    using Domain.ValueObj;
    using Factories.AbstractFactory;

    /*
     * Provê uma interface para crição de familias de objetos relacionados ou dependentes
     *      sem especificar a sua classe concreta
     */

    internal class Program
    {
        private static void Main()
        {
            var violaofactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.Violao);
            var guitarrafactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.Guitarra);
            var contraBaixoFactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.ContraBaixo);

            var violao1 = violaofactory.CriaInstrumento(ViolaoType.Takamine1ER4);
            var violao2 = violaofactory.CriaInstrumento(ViolaoType.TakamineStudio);
            var guitarra1 = guitarrafactory.CriaInstrumento(GuitarraType.IbanezGRG250);
            var guitarra2 = guitarrafactory.CriaInstrumento(GuitarraType.JacksonJ22);
            var contraBaixo1 = contraBaixoFactory.CriaInstrumento(ContraBaixoType.Fender);

            PrintInfo(violao1);
            PrintInfo(violao2);
            PrintInfo(guitarra1);
            PrintInfo(guitarra2); 
            PrintInfo(contraBaixo1);
        }

        public static void PrintInfo(InstrumentoCordaBase instrumentoCordaBase)
        {
            Console.WriteLine($"Total cordas: {instrumentoCordaBase.ObterQuantidadeCordas()} | Modelo: { instrumentoCordaBase.Modelo} | Tipo: {instrumentoCordaBase.InstrumentoType}\n");

            var index = instrumentoCordaBase.ObterQuantidadeCordas();

            foreach (var nota in instrumentoCordaBase.ListarNotas())
            {
                Console.WriteLine($"{index--}º: {nota.Info}");
            }

            Console.WriteLine("------------------------\n\n");
        }
    }
}