using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Base
{
    using Entities;
    using Interface;
    using ValueObj;

    public abstract class InstrumentoCordaBase : IInstrumentoCorda
    {
        public InstrumentoType InstrumentoType { get; set; }
        public string Modelo { get; set; }
        private short NumeroCordas { get; set; }

        protected InstrumentoCordaBase(string modelo, InstrumentoType instrumentoType, short numeroCordas)
        {
            InstrumentoType = instrumentoType;
            NumeroCordas = numeroCordas;
            Modelo = modelo;
        }

        public abstract IList<Nota> ListarNotas();
        public short ObterQuantidadeCordas() => NumeroCordas;
    }
}
