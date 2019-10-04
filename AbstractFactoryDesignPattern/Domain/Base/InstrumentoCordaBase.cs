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

        public short NumeroCordas { get; set; }

        protected InstrumentoCordaBase(InstrumentoType instrumentoType, short numeroCordas)
        {
            InstrumentoType = instrumentoType;
            NumeroCordas = numeroCordas;
        }

        public abstract IList<Nota> ListarNotas();
        public short ObterQuantidadeCordas() => NumeroCordas;
    }
}
