using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArdalisRatingService
{
    public abstract class Rater
    {
        protected readonly IRatingContext _context;
        protected readonly ConsoleLogger _logger;

        public Rater(IRatingContext context)
        {
            _context = context;
            _logger = _context.Logger;
        }

        public abstract void Rate(Policy policy);
    }
}
