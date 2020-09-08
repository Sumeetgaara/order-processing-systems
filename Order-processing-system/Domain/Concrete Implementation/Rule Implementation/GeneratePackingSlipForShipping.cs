using Order_processing_system.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_processing_system.Domain.Concrete_Implementation
{
    public class GeneratePackingSlipForShipping : IRule
    {
        public  string RuleImplementation()
        {
            //implementation is trivial
            return "Slip generated";
        }
    }
}
