namespace FactoryMethodDesignPattern.Manager.Processors
{
    using Base;
    using Domain;
    using Interfaces;

    public class CrediCardTransactionProcessor : ProcessorBase<CreditCardTransaction>, ITransactionProcessor
    {
        /// <summary>
        /// Código de simulação de autorização, apenas para fins didádicos
        /// </summary>
        /// <param name="crediCardTransaction">transação de crédito</param>
        protected override void BusinessSimulation(ref CreditCardTransaction crediCardTransaction)
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