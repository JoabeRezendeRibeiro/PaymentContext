using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
   
     public class CreditCardPayment : Payment
     {
        public CreditCardPayment(
             string cardHolderName, 
             string cardNumber, 
             string lastTransactionNumber, 
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
            CardHolderName = cardHolderName;
            CardNumber = cardNumber;
            LastTransactionNumber = lastTransactionNumber;
        }

        public string CardHolderName { get; private set; }

            public string CardNumber { get; private set; }
            
            public string LastTransactionNumber { get; private set; }


     }
}