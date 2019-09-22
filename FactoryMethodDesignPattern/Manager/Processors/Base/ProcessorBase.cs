using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethodDesignPattern.Manager.Processors.Base
{
    using System.Diagnostics;
    using Domain.Base;

    public abstract class ProcessorBase<T> where T : TransactionBase
    {
        protected T ValidateTransactionType(TransactionBase transaction)
        {
            if (!(transaction is T)) throw new ArgumentException("Invalid Transaction Type");

            return (T)transaction;
        }
    }
}
