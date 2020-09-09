using Order_processing_system.Domain.Concrete_Implementation.Rule_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_processing_system.Domain.Concrete_Implementation.Different_Entity_Implementation
{
    public class Book :  PhysicalProduct, IEntity
    {
        private readonly DuplicatePackingSlip DuplicateSlip = new DuplicatePackingSlip();
        public override string ApplyRules(string Action = "")
        {
            return base.ApplyRules() + DuplicateSlip.RuleImplementation();
        }
    }
}
