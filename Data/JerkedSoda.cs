﻿/*

* Author: Cody Reeves

* Class name: JerkedSoda.cs

* Purpose: A class representing a Jerked Soda
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing a jerked soda
    /// </summary>
    public class JerkedSoda : Drink
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
                        return 1.59;
                    case Size.Medium:
                        return 2.10;
                    case Size.Large:
                        return 2.59;
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
                        return 110;
                    case Size.Medium:
                        return 146;
                    case Size.Large:
                        return 198;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Gets the Flavor 
        /// </summary>
        public SodaFlavor Flavor { get; set; }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Ice) { instructions.Add("hold ice"); }

                return instructions;
            }
        }
    }
}
