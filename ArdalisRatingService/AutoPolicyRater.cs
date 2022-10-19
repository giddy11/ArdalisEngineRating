using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRatingService
{
    public class AutoPolicyRater : Rater
    {
        /*public AutoPolicyRater(RatingEngine engine, ConsoleLogger logger)
        {
            _engine = engine;
            _logger = logger;
        }*/

        public AutoPolicyRater(IRatingContext context) : base(context)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Rating AUTO policy...");
            _logger.Log("Validating policy.");
            if (string.IsNullOrEmpty(policy.Make))
            {
                _logger.Log("Auto policy must specify Make");
                return;
            }
            if (policy.Make == "BMW")
            {
                if (policy.Deductible < 500)
                {
                    _context.UpdateRating(1000m);
                }
                _context.UpdateRating(900m);
            }
        }








        private readonly RatingEngine _engine;  //reference to the RatingEngine
        private readonly ConsoleLogger _logger;
    }
}
