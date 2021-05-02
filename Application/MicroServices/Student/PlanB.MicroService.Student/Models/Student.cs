namespace PlanB.MicroService.Student.Models
{
    public class Student
    {
        public string CPF { get; private set; }
        //public IReadOnlyCollection<Subscription> Subscriptions { get { return _subscriptions.ToArray(); } }
        public string FirstName { get; private set; }
        public string LastName { get; private set; }

        //*public void AddSubscription(Subscription subscription)
        //{
            //var hasSubscriptionActive = false;
            //foreach (var sub in _subscriptions)
            //{
                //if (sub.Active)
                    //hasSubscriptionActive = true;
            //}

            

            //if (Valid)
                //_subscriptions.Add(subscription);
            // Alternativa
            // if (hasSubscriptionActive)
            //     AddNotification("Student.Subscriptions", "Você já tem uma assinatura ativa");
        //}
    }
}