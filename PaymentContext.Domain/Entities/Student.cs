using System.Collections.Generic;
using System.Linq;

namespace PaymentContext.Domain.Entities
{
public class Student
{
    private IList<Subscription> _subscriptions;
        public Student(string fistName, string lastName, string document, string email)
        {
            FistName = fistName;
            LastName = lastName;
            Document = document;
            Email = email;
            _subscriptions = new List<Subscription>();
        
            
        }

    public string FistName { get; private set; }

    public string LastName { get; private set; }

    public string Document { get; private set; }
    
    public string Email { get; private set; }

    public string Adress { get; private set; }

    public IReadOnlyCollection<Subscription> Subscriptions {get { return _subscriptions.ToArray();}}

    public void AddSubscripition(Subscription subscription)
    {
        // Se tiver uma assinatura ativa cancela
        // Cancela todas as outras de deixa essa como principal
        foreach(var sub in Subscriptions)
            sub.Inactivate();

        _subscriptions.Add(subscription);
    }

}

}