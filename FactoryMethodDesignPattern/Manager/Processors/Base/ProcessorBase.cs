using System;

namespace FactoryMethodDesignPattern.Manager.Processors.Base
{
    using Domain;
    using Domain.Base;
    using Manager.Processors.Interfaces;

    public abstract class ProcessorBase<T> where T : TransactionBase
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var transactionType = ValidateTransactionType(transaction);

            return ProcessAuthorization(transactionType);
        }

        protected T ValidateTransactionType(TransactionBase transaction)
        {
            if (!(transaction is T)) throw new ArgumentException("Invalid Transaction Type");

            return (T)transaction;
        }

        protected TransactionInfo ProcessAuthorization(T transaction)
        {
            transaction.SetStatusInProgress();

            BusinessSimulation(ref transaction);

            return new TransactionInfo(transaction.TransactionKey,
                transaction.CreateDate, transaction.Amount,
                    transaction.TransactionStatusType);
        }

        protected abstract void BusinessSimulation(ref T crediCardTransaction);
    }
}