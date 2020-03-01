﻿/*

* Author: Cody Reeves

* Class name: CornDodgers.cs

* Purpose: A class representing the Corn Dodgers side

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Corn Dodgers side
    /// </summary>
    public class CornDodgers : Side
    {
        /// <summary>
        /// The calories of each size of the side
        /// </summary>
        public override uint Calories
        {
            get
            {
                switch (Size)
                {
                    case Size.Small:
                        return 512;
                    case Size.Medium:
                        return 685;
                    case Size.Large:
                        return 717;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// The price of each size of the side
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
                        return 1.79;
                    case Size.Large:
                        return 1.99;
                    default:
                        throw new NotImplementedException();
                }
            }
        }

        /// <summary>
        /// Implementation of the SpecialInstructions property
        /// so that it can be added to the order
        /// </summary>
        public override List<string> SpecialInstructions => new List<string>();

        /// <summary>
        /// Creates a readable string
        /// </summary>
        /// <returns>The formatted string</returns>
        public override string ToString()
        {
            return $"{Size} Corn Dodgers";
        }
    }
}
