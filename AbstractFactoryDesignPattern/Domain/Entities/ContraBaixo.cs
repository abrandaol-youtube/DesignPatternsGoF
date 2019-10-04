using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    using Base;
    using ValueObj;

    public sealed class ContraBaixo : InstrumentoCordaBase
    {
        public ContraBaixo() : base(InstrumentoType.ContraBaixo, 4)
        {
        }

        public override IList<Nota> ListarNotas() => new List<Nota>
        {
            new Nota("Lá", 440.00M),
            new Nota("Ré", 293.66M),
            new Nota("Sol", 391.99M),
            new Nota("Si", 493.88M),
        };
    }
}
