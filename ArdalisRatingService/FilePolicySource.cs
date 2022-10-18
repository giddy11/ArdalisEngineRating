using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRatingService
{
    public class FilePolicySource
    {
        public string GetPolicyFromSource()
        {
            //Directory.CreateDirectory(Path.Combine(Directory.GetCurrentDirectory(), "New folder"));


            //return File.ReadAllText("C:\\Users\\gideon.edoghotu\\Desktop\\PersonalStudies\\SOLIDPrinciple\\ArdalisRatingService\\policy.json");

            return File.ReadAllText("policy.json");

            //return File.ReadAllText(null); 
            // SRP  --> Can it be applied to other parts of the codebase apart from classes?
        }
    }
}
