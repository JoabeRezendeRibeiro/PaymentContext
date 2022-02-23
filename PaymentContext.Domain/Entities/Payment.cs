using System;
using PaymentContext.Domain.ValueObjects;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment 
    {
        protected Payment(
        DateTime paiddate, 
        DateTime expireDate, 
        decimal total, 
        Document document, 
        string payer, 
        decimal totalPaid, 
        Adress adress, 
        Email email)
        {
            Number = Guid.NewGuid().ToString().Replace("-","").Substring(0,10).ToUpper();
            PaidDate = paiddate;
            ExpireDate = expireDate;
            Total = total;
            Document = document;
            Payer = payer;
            TotalPaid = totalPaid;
            Adress = adress;
            Email = email;
        }

        public string Number { get; private set; }

        public DateTime PaidDate { get; private set; }

        public DateTime ExpireDate { get; private set; }

        public decimal Total { get; private set; }

        public Document Document { get; private set; }

        public string Payer { get; private set; }

        public decimal TotalPaid { get; private set; }

        public Adress Adress { get; private set; }

        public Email Email { get; private set; }


    }
     
}