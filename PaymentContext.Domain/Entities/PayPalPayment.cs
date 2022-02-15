using System;

namespace PaymentContext.Domain.Entities
{
    
     public class PayPalPayment : Payment
     {
        public PayPalPayment(
           string transactionCode, 
           DateTime paiddate, 
           DateTime expireDate, 
           decimal total, 
           string document, 
           string payer, 
           decimal totalPaid, 
           string adress, 
           string email):base( 
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