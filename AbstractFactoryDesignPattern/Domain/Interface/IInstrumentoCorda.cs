using System.Collections.Generic;

namespace AbstractFactoryDesignPattern.Domain.Interface
{
    using Entities;

    public interface IInstrumentoCorda
    {
        IList<Nota> ListarNotas();

        short ObterQuantidadeCordas();
    }
}