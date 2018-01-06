using System;
using System.Linq;

namespace Bowling
{
    public class Frame
    {
        
        private int[] pinsKnockedDown;

        public Frame(int[] pinsKnockedDown)
        {
            this.pinsKnockedDown = pinsKnockedDown;
        }

        public int Score
        {
            get
            {
                if (this.IsOpenFrame) return this.pinsKnockedDown.Sum();

                throw (new NotImplementedException());
            }
        }

        public bool IsOpenFrame => (pinsKnockedDown.Sum() < 10);
    }
}