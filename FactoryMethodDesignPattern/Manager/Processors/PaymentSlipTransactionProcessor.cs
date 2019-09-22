using System;

namespace FactoryMethodDesignPattern.Manager.Processors
{
    using Base;
    using Domain;
    using Domain.Base;
    using Interfaces;

    public class PaymentSlipTransactionProcessor: ProcessorBase<PaymentSlipTransaction>, ITransactionProcessor
    {
        public TransactionInfo Authorize(TransactionBase transaction)
        {
            var paymentSlipTransaction = ValidateTransactionType(transaction);

            return ProcessAuthorization(paymentSlipTransaction);
        }

        private static TransactionInfo ProcessAuthorization(PaymentSlipTransaction paymentSlipTransaction)
        {
            paymentSlipTransaction.SetStatusInProgress();

            BusinessSimulation(ref paymentSlipTransaction);

            return new TransactionInfo(paymentSlipTransaction.TransactionKey,
                paymentSlipTransaction.CreateDate, paymentSlipTransaction.Amount, 
                    paymentSlipTransaction.TransactionStatusType);
        }

        /// <summary>
        /// Código de simulação de autorização, apenas para fins didádicos
        /// </summary>
        /// <param name="paymentSlipTransaction">transação de boleto</param>
        private static void BusinessSimulation(ref PaymentSlipTransaction paymentSlipTransaction)
        {
            /* Autoriza se o valor estiver entre 100 e 20.000 reais e a
                    data de vencimento for maior que a data atual  */
            if (paymentSlipTransaction.Amount >= 100 
                && paymentSlipTransaction.Amount <= 20000 
                    && paymentSlipTransaction.DueDate.Date >= DateTime.UtcNow.Date)
            {
                paymentSlipTransaction.SetStatusAuthorized();

                return;
            }

            paymentSlipTransaction.SetStatusUnauthorized();
        }
    }
}
