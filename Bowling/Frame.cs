using System;
using System.Collections.Generic;

namespace Bowling
{
    public class Frame
    {
        
        private int[] pins;

        public Frame(int[] pins)
        {
            this.pins = pins;
        }

        public int PinTotal
        {
            get
            {
                throw (new NotImplementedException());
            }
        }
    }
}