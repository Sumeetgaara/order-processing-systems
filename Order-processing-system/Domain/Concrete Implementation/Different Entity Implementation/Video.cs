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
        private List<string> FirstAidFilterVideoList = new List<string>();
        public string VideoName { get; }
        public Video(string videoname)
        {
            VideoName = videoname;
            PopulateFirstAidFilterVideoList();

        }

        public string ApplyRules(string Action = "") =>  FirstAidFilterVideoList.Contains(VideoName)? FirstAdd.RuleImplementation() :  "default values";
      
        private void PopulateFirstAidFilterVideoList()
        {
            // can be populated using DB
            FirstAidFilterVideoList.Add("Learning to Ski");
        }
    }
}
