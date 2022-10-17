namespace ArdalisRatingService
{
    internal class UnKnownPolicyRater : Rater
    {
        public UnKnownPolicyRater(RatingEngine engine, ConsoleLogger logger) : base(engine, logger)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown policy type");
        }
    }
}