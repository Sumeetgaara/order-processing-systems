using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_processing_system.Domain.Concrete_Implementation
{
    public class PhysicalProduct : IEntity
    {
        private readonly GeneratePackingSlipForShipping GenerateSlipRule = new GeneratePackingSlipForShipping();
        private readonly CommissionPayment ComPayment = new CommissionPayment();

        public string ApplyRules()
        {
            return GenerateSlipRule.RuleImplementation() + ComPayment.RuleImplementation();
        }
    }
}
