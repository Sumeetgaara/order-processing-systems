using Order_processing_system.Domain.Concrete_Implementation.Rule_Implementation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Order_processing_system.Domain.Concrete_Implementation.Different_Entity_Implementation
{
    public class Video : IEntity
    {
        private readonly FirstAid FirstAdd = new FirstAid();
        public string VideoName { get; }
        public Video(string videoname)
        {
            VideoName = videoname;
        }
        public string ApplyRules(string Action = "")
        {
            switch (VideoName)
            {
                case "Learning to Ski":     
                    return FirstAdd.RuleImplementation();
                default:
                    return "default values";  // can be updated according to domain logic.
            }
        }
    }
}
