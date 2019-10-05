﻿using System;

namespace FactoryMethodDesignPattern
{
    using Domain;
    using Domain.ValueObj;
    using Manager.Factory;

    /*
     *  Factory Method
     *
     *  Define uma interface de criação de objeto, mas deixa a sua subclasse decidir qual classe deve ser instânciada
     *  É considerado um "Construtor virtual"
     */

    internal class Program
    {
        private static void Main(string[] args)
        {
            #region CreditCard Transaction
            
            var creditCardTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.CreditCard);

            var creditCardTransaction = new CreditCardTransaction(
                1000, "Joe Satriani", "222", "1111222233334444");
            
            var creditCardTransactionInfo = creditCardTransactionProcessor.Authorize(creditCardTransaction);

            Console.WriteLine($"{creditCardTransactionInfo.Amount} | {creditCardTransactionInfo.CreateDate:g} | " +
                              $"{creditCardTransactionInfo.TransactionKey} | {creditCardTransactionInfo.TransactionStatusType}");

            #endregion

            #region Debit Transaction

            var debitTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.Debit);

            var debitTransaction = new DebitTransaction(1300, "Banco Itaú");

            var debitTransactionInfo = debitTransactionProcessor.Authorize(debitTransaction);

            Console.WriteLine($"{debitTransactionInfo.Amount} | {debitTransactionInfo.CreateDate:g} | " +
                              $"{debitTransactionInfo.TransactionKey} | {debitTransactionInfo.TransactionStatusType}");

            #endregion

            #region PaymentSlip Transaction

            var paymentSlipTransactionProcessor =
                TransactionProcessorFactory.CreateTransactionProcessor(TransactionType.PaymentSlip);

            var paymentSlipTransaction = new PaymentSlipTransaction(2000, "001", "0000-0000", DateTime.Now);

            var paymentSlipTransactionInfo = paymentSlipTransactionProcessor.Authorize(paymentSlipTransaction);

            Console.WriteLine($"{paymentSlipTransactionInfo.Amount} | {paymentSlipTransactionInfo.CreateDate:g} | " +
                              $"{paymentSlipTransactionInfo.TransactionKey} | {paymentSlipTransactionInfo.TransactionStatusType}");

            #endregion
        }
    }
}