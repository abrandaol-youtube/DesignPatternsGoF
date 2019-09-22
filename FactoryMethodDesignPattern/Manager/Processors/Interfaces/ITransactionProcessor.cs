namespace FactoryMethodDesignPattern.Manager.Processors.Interfaces
{
    using System.Transactions;
    using Domain;
    using Domain.Base;

    public interface ITransactionProcessor
    {
        TransactionInfo Authorize(TransactionBase transaction);
    }
}