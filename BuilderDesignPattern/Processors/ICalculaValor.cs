using System;
using System.Collections.Generic;
using System.Text;

namespace BuilderDesignPattern.Processors
{
    using Domain;

    public interface ICalculaValor
    {
        void DefineValor(Pizza pizza);
    }
}
