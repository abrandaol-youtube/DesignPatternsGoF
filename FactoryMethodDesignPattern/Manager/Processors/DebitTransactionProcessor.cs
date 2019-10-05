namespace FactoryMethodDesignPattern.Manager.Processors
{
    using Base;
    using Domain;
    using Interfaces;

    public class DebitTransactionProcessor : ProcessorBase<DebitTransaction>, ITransactionProcessor
    {
        /// <summary>
        /// Código de simulação de autorização, apenas para fins didádicos
        /// </summary>
        /// <param name="debitTransaction">transação de débito</param>
        protected override void BusinessSimulation(ref DebitTransaction debitTransaction)
        {
            // Autoriza se o valor estiver entre 1 e 5.000 reais

            if (debitTransaction.Amount >= 1
                && debitTransaction.Amount <= 5000)
            {
                debitTransaction.SetStatusAuthorized();

                return;
            }

            debitTransaction.SetStatusUnauthorized();
        }
    }
}