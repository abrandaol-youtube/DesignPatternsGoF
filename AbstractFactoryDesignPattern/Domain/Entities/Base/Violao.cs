namespace AbstractFactoryDesignPattern.Domain.Entities.Base
{
    using System.Collections.Generic;
    using Domain.Base;
    using ValueObj;

    public abstract class Violao : InstrumentoCordaBase
    {
        protected Violao(string modelo, short numeroCordas) : base(modelo, InstrumentoType.Violao, numeroCordas)
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
        };
    }
}