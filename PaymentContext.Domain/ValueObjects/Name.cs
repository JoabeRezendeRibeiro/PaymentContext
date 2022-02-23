using PaymentContext.Shared.ValueObjetcs;
using Flunt.Notifications;


namespace PaymentContext.Domain.ValueObjects
{
    public class Name : ValueObject
    {
        public Name(string fistName, string lastName)
        {
            FistName = fistName;
            LastName = lastName;

            if (string.IsNullOrEmpty(FistName))
            AddNotification("Name.FistName", "Nome invalido");
        
        }

        public string FistName { get; private set; }
        public string LastName { get; private set; }
    }
}