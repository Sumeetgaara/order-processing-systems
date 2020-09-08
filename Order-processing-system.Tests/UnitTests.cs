using Order_processing_system.Domain;
using Order_processing_system.Domain.Concrete_Implementation;
using System;
using Xunit;

namespace Order_processing_system.Tests
{
    public class UnitTests
    {
        [Fact]
        public void IfPaymentIsPhysicalProduct()
        {
            IEntity Product = new PhysicalProduct();
            Assert.Equal(new GeneratePackingSlipForShipping().RuleImplementation() + new CommissionPayment().RuleImplementation(),Product.ApplyRules());
        }
    }
}
