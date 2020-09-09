using Order_processing_system.Domain.Concrete_Implementation.Rule_Implementation;
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
        private readonly MembershipUpgrade Upgrade = new MembershipUpgrade();

        public virtual string ApplyRules(string Action = "")
        {
            return Action switch
            {
                "Activation" => ActivateMemberShip(),
                "Upgrade" => UpgradeMemberShip(),
                _ => "default"
            };
        }

        private string ActivateMemberShip()
        {
            //implementation is trivial
            return Activation.RuleImplementation();

        }

        private string UpgradeMemberShip()
        {
            //implementation is trivial
            return Upgrade.RuleImplementation();
        }
    }
}
