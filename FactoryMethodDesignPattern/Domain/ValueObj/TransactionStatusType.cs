namespace FactoryMethodDesignPattern.Domain.ValueObj
{
    public enum TransactionStatusType
    {
        /// <summary>
        /// Autorizada
        /// </summary>
        Authorized = 0,

        /// <summary>
        /// Negada, não autorizada
        /// </summary>
        Unauthorized = 1,

        /// <summary>
        /// Não enviada para processo de autorização
        /// </summary>
        Pending = 2,

        /// <summary>
        /// Em processo de autorização
        /// </summary>
        InProgress = 3
    }
}