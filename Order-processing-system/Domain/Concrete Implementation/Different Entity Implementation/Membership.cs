﻿using Order_processing_system.Domain.Concrete_Implementation.Rule_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_processing_system.Domain.Concrete_Implementation.Different_Entity_Implementation
{
    public class Membership : IEntity
    {
        private readonly MembershipActivation Activation = new MembershipActivation();
        public virtual string ApplyRules()
        {
            return Activation.RuleImplementation();
        }

    }
}
