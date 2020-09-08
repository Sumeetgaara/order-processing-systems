using Order_processing_system.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_processing_system.Domain.Concrete_Implementation.Rule_Implementation
{
    public class MembershipEmail : IRule
    {
        public virtual string RuleImplementation()
        {
            //implementation is trivial
            return "Email Sent";
        }
    }
}
