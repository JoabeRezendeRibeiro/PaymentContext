using System;
using PaymentContext.Domain.Entities;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    
    }
    public class BoletoPayment : Payment
    {
    public BoletoPayment(
          string barcode, 
            string boletoNumber,
            DateTime paiddate, 
           DateTime expireDate, 
           decimal total, 
           Document document, 
           string payer, 
           decimal totalPaid, 
           Adress adress, 
           Email email) : base( 
              paiddate,  
              expireDate,  
              total,  
              document,  
              payer,  
              totalPaid,  
              adress,  
              email)
    {
        Barcode = barcode;
        BoletoNumber = boletoNumber;
    }

    public string Barcode { get; private set; } 

          public string BoletoNumber {get; private set; }

    }
     