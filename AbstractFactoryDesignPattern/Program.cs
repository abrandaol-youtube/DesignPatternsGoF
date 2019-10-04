using System;

namespace AbstractFactoryDesignPattern
{
    using System.Net;
    using System.Runtime.InteropServices;
    using Domain.Base;
    using Domain.ValueObj;
    using Factories.AbstractFactory;

    internal class Program
    {
        private static void Main()
        {
            var violaofactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.Violao);
            var guitarrafactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.Guitarra);
            var contraBaixoFactory = InstrumentoCordaAbstractFactory.CriaFabrica(InstrumentoType.ContraBaixo);

            var violao1 = violaofactory.CriaInstrumento("Takamine Stduio");
            var violao2 = violaofactory.CriaInstrumento("Takamine 1RE4");
            var guitarra11 = guitarrafactory.CriaInstrumento("Ibanez GRG 350");
            var guitarra12 = guitarrafactory.CriaInstrumento("Ibanez GRG 250");
            var guitarra13 = guitarrafactory.CriaInstrumento("Jackson J22");
            var contraBaixo1 = contraBaixoFactory.CriaInstrumento("Fender");

            PrintInfo(violao1);
            PrintInfo(violao2);
            PrintInfo(guitarra11);
            PrintInfo(guitarra12);
            PrintInfo(guitarra13);
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
