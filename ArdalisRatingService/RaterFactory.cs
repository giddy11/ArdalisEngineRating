using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRatingService
{
    public class RaterFactory
    {
        public Rater Create(Policy policy, RatingEngine engine)
        {
            try
            {
                return (Rater)Activator.CreateInstance(
                    Type.GetType($"ArdalisRatingService.{policy.Type}PolicyRater"),
                    new object[] { engine, engine.Logger });
            }
            catch
            {
                return null;
            }
            
            //switch (policy.Type)
            //{
            //    case PolicyType.Auto:
            //        return new AutoPolicyRater(engine, engine.Logger);

            //    case PolicyType.Land:
            //        return new LandPolicyRater(engine, engine.Logger);

            //    case PolicyType.Life:
            //        return new LifePolicyRater(engine, engine.Logger);

            //    case PolicyType.Flood:
            //        return new FloodPolicyRater(engine, engine.Logger);

            //    default:
            //        //currently this can't be reached
            //        return new UnKnownPolicyRater(engine, engine.Logger);

            //}
        }




        /*
         Reflection is introduced so that we dont have to use switch statement inside this class
         
         */
    }
}
