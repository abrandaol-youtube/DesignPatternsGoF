namespace FactoryMethodDesignPattern.Domain
{
    using Base;
    using ValueObj;

    public sealed class CreditCardTransaction : TransactionBase
    {
        public string HolderName { get; }
        public string SecurityCode { get; }
        public string CardNumber { get; }

        public CreditCardTransaction(double amount, string holderName, string securityCode, string cardNumber)
            : base(TransactionType.CreditCard, amount)
        {
            HolderName = holderName;
            SecurityCode = securityCode;
            CardNumber = cardNumber;
        }
    }
}