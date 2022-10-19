using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRatingService
{
    public interface IRatingContext
    {
        ConsoleLogger Logger { get; }
        void Log(string message);
        RatingEngine Engine { get; set; }
        Policy GetPolicyFromJsonString(string policyJson);
        string LoadPolicyFromFile();
        string LoadPolicyFromURI(string uri);
        Policy GetPolicyFromXmlString(string policyXml);
        Rater CreateRaterForPolicy(Policy policy, IRatingContext context);
        void UpdateRating(decimal rating);
    }
}
