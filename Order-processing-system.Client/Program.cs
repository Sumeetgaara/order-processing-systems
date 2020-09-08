using Order_processing_system.Domain.Concrete_Implementation;
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

            Console.ReadKey();

        }
    }
}
