using System;
using SimplifiedATS.AS.Impl;
using SimplifiedATS.BillingSystemModel.Impl;

namespace SimplifiedATS
{
    class Program
    {
        static void Main(string[] args)
        {
            Station station = new Station();
            BillingSystem billingSystem = new BillingSystem();

            User user1 = new User("Vasya", "Levashko");
            User user2 = new User("Lesha", "Kazakov");

            station.CreateAgreement(user1);
            station.CreateAgreement(user2);
          
            user1.Terminal.Call(user2.Terminal.Number);
            user1.Terminal.EndCall();

            

            Console.ReadLine();
        }
    }

    
}

