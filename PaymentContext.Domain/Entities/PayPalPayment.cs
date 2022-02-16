using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    
     public class PayPalPayment : Payment
     {
        public PayPalPayment(
           string transactionCode, 
           DateTime paiddate, 
           DateTime expireDate, 
           decimal total, 
           Document document, 
           string payer, 
           decimal totalPaid, 
           Adress adress, 
           Email email):base( 
              paiddate,  
              expireDate,  
              total,  
              document,  
              payer,  
              totalPaid,  
              adress,  
              email)
        {
            TransactionCode = transactionCode;
        }

        public string TransactionCode { get; private set; }

     }
     
}