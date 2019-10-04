using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    using Base;
    using ValueObj;

    public sealed class Guitarra : InstrumentoCordaBase
    {
        public Guitarra() : base(InstrumentoType.Guitarra, 7)
        {
        }

        public override IList<Nota> ListarNotas() => new List<Nota>
        {
            new Nota("Mi", 329.63M),
            new Nota("Lá", 440.00M),
            new Nota("Ré", 293.66M),
            new Nota("Sol", 391.99M),
            new Nota("Si", 493.88M),
            new Nota("Mi", 329.63M),
            new Nota("Dó", 261.63M)
        };
    }
}
