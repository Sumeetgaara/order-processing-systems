﻿using Order_processing_system.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_processing_system.Domain.Concrete_Implementation.Rule_Implementation
{
    public class FirstAid : IRule
    {
        public string RuleImplementation()
        {
            return "Added first aid video";
        }
    }
}
