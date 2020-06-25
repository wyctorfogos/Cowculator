using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cowculator
{
    class Farmer
    {
        public const int feedMultiplier = 30;
        private int numberOfCows;
        public int FeedMultiplier { get { return feedMultiplier; } }

        public int NumberOfCows { get => numberOfCows; set => numberOfCows = value; }

        public int BagsOfFeed(int numberOfCows)
        {
            int result = numberOfCows * feedMultiplier;
            return result;
        }
    }
}
