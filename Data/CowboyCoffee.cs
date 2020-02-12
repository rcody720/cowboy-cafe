using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class CowboyCoffee : Drink
    {
        /// <summary>
        /// Gets the price 
        /// </summary>
        public override double Price
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 0.60;
                    case Size.Medium:
                        return 1.10;
                    case Size.Large:
                        return 1.60;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the calories
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 3;
                    case Size.Medium:
                        return 5;
                    case Size.Large:
                        return 7;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets if it should be decaf
        /// </summary>
        public bool Decaf { get; set; }

        /// <summary>
        /// Gets if there should be room for cream
        /// </summary>
        public bool RoomForCream { get; set; }

        /// <summary>
        /// Gets if there should be Ice
        /// </summary>
        public override bool Ice { get; set; } = false;

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Ice) { instructions.Add("add ice"); }
                if (RoomForCream) { instructions.Add("add room for cream"); }
                return instructions;
            }
        }
    }
}
