namespace ArdalisRatingService
{
    internal class UnKnownPolicyRater : Rater
    {
        public UnKnownPolicyRater(IRatingContext context) : base(context)
        {
        }

        public override void Rate(Policy policy)
        {
            _logger.Log("Unknown policy type");
        }
    }
}