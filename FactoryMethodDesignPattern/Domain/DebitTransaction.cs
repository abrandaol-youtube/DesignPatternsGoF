namespace FactoryMethodDesignPattern.Domain
{
    using Base;
    using ValueObj;

    public sealed class DebitTransaction : TransactionBase
    {
        public string BankName { get; }

        public DebitTransaction(double amount, string bankName) : base(TransactionType.Debit, amount)
        {
            BankName = bankName;
        }
    }
}