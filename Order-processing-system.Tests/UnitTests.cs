using Order_processing_system.Domain;
using Order_processing_system.Domain.Concrete_Implementation;
using Order_processing_system.Domain.Concrete_Implementation.Different_Entity_Implementation;
using Order_processing_system.Domain.Concrete_Implementation.Rule_Implementation;
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

        [Fact]
        public void IfPaymentIsBook()
        {
            IEntity Product = new Book();
            Assert.Equal(new GeneratePackingSlipForShipping().RuleImplementation() + new CommissionPayment().RuleImplementation() + new DuplicatePackingSlip().RuleImplementation() , Product.ApplyRules());
        }

        [Fact]
        public void IfPaymentIsMembershipActivation()
        {
            IEntity Product = new Membership();
            Assert.Equal(new MembershipActivation().RuleImplementation(), Product.ApplyRules("Activation"));
        }
    }
}
