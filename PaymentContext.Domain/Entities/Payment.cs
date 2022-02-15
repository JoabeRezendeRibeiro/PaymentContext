using System;

namespace PaymentContext.Domain.Entities
{
    public abstract class Payment
    {
        protected Payment(DateTime paiddate, DateTime expireDate, decimal total, string document, string payer, decimal totalPaid, string adress, string email)
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

        public string Document { get; private set; }

        public string Payer { get; private set; }

        public decimal TotalPaid { get; private set; }

        public string Adress { get; private set; }

        public string Email { get; private set; }


    }
     
}