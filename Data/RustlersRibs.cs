using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class RustlersRibs
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price
        {
            get { return 7.50; }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories
        {
            get { return 894; }
        }

        /// <summary>
        /// The Special Instructions for making the entree
        /// </summary>
        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                return instructions;
            }
        }


    }
}
