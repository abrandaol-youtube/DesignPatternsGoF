using System;

namespace FactoryMethodDesignPattern.Domain.Base
{
    using System.Data;
    using ValueObj;

    public abstract class TransactionBase
    {
        public TransactionType TransactionType { get; set; }

        protected TransactionBase(TransactionType transactionType, double amount)
        {
            TransactionType = transactionType;
            Amount = amount;
            TransactionKey = Guid.NewGuid();
            CreateDate = DateTime.UtcNow;
            TransactionStatusType = TransactionStatusType.Pending;
        }

        public Guid TransactionKey { get; }
        public DateTime CreateDate { get; }
        public double Amount { get; }
        public TransactionStatusType TransactionStatusType { get; }

        public bool SetStatusInProgress()
        {
            StatusTransitionValidate(TransactionStatusType.InProgress);

            return true;
        }

        public bool SetStatusAuthorized()
        {
            StatusTransitionValidate(TransactionStatusType.Authorized);

            return true;
        }

        public bool SetStatusUnauthorized()
        {
            StatusTransitionValidate(TransactionStatusType.Unauthorized);

            return true;
        }

        private bool StatusTransitionValidate(TransactionStatusType desiredTransactionStatusType)
        {
            if (this.TransactionStatusType == desiredTransactionStatusType)
            {
                throw new ConstraintException("No transaction status transition");
            }

            if ((int)this.TransactionStatusType < (int)desiredTransactionStatusType)
            {
                throw new ConstraintException("Invalid transaction status transition");
            }

            if ((int)this.TransactionStatusType <= 1)
            {
                throw new ConstraintException("Invalid transaction status transition from end state process");
            }

            return true;
        }
    }
}