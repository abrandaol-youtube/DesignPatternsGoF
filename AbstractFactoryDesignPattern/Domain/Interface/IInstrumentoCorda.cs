using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactoryDesignPattern.Domain.Interface
{
    using Entities;

    public interface IInstrumentoCorda
    {
        IList<Nota> ListarNotas();
        short ObterQuantidadeCordas();
    }
}
