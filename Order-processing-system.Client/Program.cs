using Order_processing_system.Domain.Concrete_Implementation;
using Order_processing_system.Domain.Concrete_Implementation.Different_Entity_Implementation;
using System;

namespace Order_processing_system.Client
{
    class Program
    {
        static void Main(string[] args)
        {
            //Physical Product Use Case
            var PhysicalProductPayment = new PhysicalProduct();
            Console.WriteLine(PhysicalProductPayment.ApplyRules());

            //Book Use case
            var BookPayment = new Book();
            Console.WriteLine(BookPayment.ApplyRules());

            //Membership use case
            var MembershipPayment = new Membership();
            Console.WriteLine(MembershipPayment.ApplyRules("Activation"));

            //Video use case
            var VideoPayment = new Video("Learning to Ski");
            Console.WriteLine(VideoPayment.ApplyRules());

            Console.ReadKey();

        }
    }
}
