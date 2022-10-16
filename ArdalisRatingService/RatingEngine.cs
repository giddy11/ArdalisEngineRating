// See https://aka.ms/new-console-template for more information


using ArdalisRatingService;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

public class RatingEngine
{
    /// <summary>
    /// The RatingEngine reads the policy application details from a file and produces a numeric
    /// rating value based on the details.
    /// </summary>


    public RatingEngine()
    {
    }

    public void Rate()
    {
        Logger.Log("Starting rate.");
        Logger.Log("Loading policy.");

        // load policy - open file policy.json
        string policyJson = PolicySource.GetPolicyFromSource();

        var policy = JsonConvert.DeserializeObject<Policy>(policyJson, new StringEnumConverter());

        switch (policy.Type)
        {
            case PolicyType.Life:
                var rater = new LifePolicyRater(this, this.Logger);
                rater.Rate(policy);
                break;

            case PolicyType.Land:
                var rater2 = new LandPolicyRater(this, this.Logger);
                rater2.Rate(policy);
                break;

            case PolicyType.Auto:
                var rater3 = new AutoPolicyRater(this, this.Logger);
                rater3.Rate(policy);
                break;

            default:
                Logger.Log("Unknown policy type");
                break;
        }

        Logger.Log("Rating completed.");
    }

    public decimal Rating { get; set; }
    public ConsoleLogger Logger { get; set; } //= new ConsoleLogger();
    public FilePolicySource PolicySource { get; set; } = new FilePolicySource();







    /*
      Looking at the RatingEngine itself, it has one method of interest, which is the Rate method.

    It will load a policy file into a string and then deserialize that into a policy type using JSON to convert it.
     
    Then it will determine what type of policy is to be rated. The system currently supports different policy types.

    We have the Auto policy. it will do a lil bit of validation to verify that certain key elements exist within the policy document, then it will perform complex business rules to determine what the rating should be based on the details provided inside of the policy.

    We also have the Land policy, which calculates the bond amount for the land in the busines logic
    We also have the life insurance options
    Finally, if the system doesnt recognize the type of policy provided, it will simply log that out to the console, and once whatever type of rating has been performed, the system writes out that the rating was complete.
     
     
     
     */
}