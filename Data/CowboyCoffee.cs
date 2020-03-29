/*

* Author: Cody Reeves

* Class name: CowboyCoffee.cs

* Purpose: A class representing the Cowboy Coffee drink

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Cowboy Coffee Drink
    /// </summary>
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

        private bool decaf = false;
        /// <summary>
        /// Gets if it should be decaf
        /// </summary>
        public bool Decaf
        {
            get
            {
                return decaf;
            }
            set
            {
                decaf = value;
                NotifyOfPropertyChange("Decaf");
            }
        }

        private bool roomForCream = false;
        /// <summary>
        /// Gets if there should be room for cream
        /// </summary>
        public bool RoomForCream
        {
            get
            {
                return roomForCream;
            }
            set
            {
                roomForCream = value;
                NotifyOfPropertyChange("RoomForCream");
            }
        }

        private bool ice = false;
        /// <summary>
        /// Gets if there should be Ice
        /// </summary>
        public override bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyOfPropertyChange("Ice");
            }
        }

        /// <summary>
        /// Gets the special instructions
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (Ice) { instructions.Add("Add Ice"); }
                if (RoomForCream) { instructions.Add("Room for Cream"); }
                return instructions;
            }
        }

        /// <summary>
        /// Creates a readable string
        /// </summary>
        /// <returns>The formatted string</returns>
        public override string ToString()
        {
            if (Decaf)
            {
                return $"{Size} Decaf Cowboy Coffee";
            }
            else
            {
                return $"{Size} Cowboy Coffee";
            }            
        }
    }
}
