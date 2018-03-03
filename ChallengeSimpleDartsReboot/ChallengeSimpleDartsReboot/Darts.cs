using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace ChallengeSimpleDartsReboot
{
    public class Darts
    {
        public int Score { get; set; }
        public bool IsDouble { get; set; }
        public bool IsTriple { get; set; }

        private Random _random;

        public Darts(Random random)
        {
            _random = random;
        }

        public void Throw()
        {
            Score = _random.Next(0, 21);

            int multiplier = _random.Next(1, 101);
            if (multiplier > 95) IsTriple = true;
            else if (multiplier > 90) IsDouble = true;
        }
    }
}
