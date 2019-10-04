using System.Collections.Generic;

namespace AbstractFactoryDesignPattern.Domain.Entities
{
    using Base;
    using ValueObj;

    public sealed class ContraBaixo : InstrumentoCordaBase
    {
        public ContraBaixo(string modelo) : base(modelo, InstrumentoType.ContraBaixo, 4)
        {
        }

        public override IList<Nota> ListarNotas() => new List<Nota>
        {
            new Nota("Mi", 30.86M),
            new Nota("Lá", 55.00M),
            new Nota("Ré", 73.40M),
            new Nota("Sol", 98.00M)
        };
    }
}