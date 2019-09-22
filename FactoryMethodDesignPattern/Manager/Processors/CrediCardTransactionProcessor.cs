namespace FactoryMethodDesignPattern.Manager.Processors
{
    using Base;
    using Domain;
    using Domain.Base;
    using Interfaces;

    public class CrediCardTransactionProcessor : ProcessorBase<CreditCardTransaction>, ITransactionProcessor
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var crediCardTransaction = ValidateTransactionType(transaction);

            return ProcessAuthorization(crediCardTransaction);
        }

        private static TransactionInfo ProcessAuthorization(CreditCardTransaction crediCardTransaction)
        {
            crediCardTransaction.SetStatusInProgress();

            BusinessSimulation(ref crediCardTransaction);

            return new TransactionInfo(crediCardTransaction.TransactionKey,
                crediCardTransaction.CreateDate, crediCardTransaction.Amount,
                    crediCardTransaction.TransactionStatusType);
        }

        /// <summary>
        /// Código de simulação de autorização, apenas para fins didádicos
        /// </summary>
        /// <param name="crediCardTransaction">transação de crédito</param>
        private static void BusinessSimulation(ref CreditCardTransaction crediCardTransaction)
        {
            // Autoriza se o valor estiver entre 10 e 12.000 reais

            if (crediCardTransaction.Amount >= 10
                && crediCardTransaction.Amount <= 12000)
            {
                crediCardTransaction.SetStatusAuthorized();

                return;
            }

            crediCardTransaction.SetStatusUnauthorized();
        }
    }
}