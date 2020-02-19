/*

* Author: Cody Reeves

* Class name: PecosPulledPork.cs

* Purpose: A class representing the Pecos Pulled Pork entree

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Pecos Pulled Pork entree
    /// </summary>
    public class PecosPulledPork : Entree
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public override double Price
        {
            get { return 5.88; }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get { return 528; }
        }

        /// <summary>
        /// If the entree should have bread
        /// </summary>
        public bool Bread { get; set; } = true;

        /// <summary>
        /// If the entree should have pickle
        /// </summary>
        public bool Pickle { get; set; } = true;

        /// <summary>
        /// The Special Instructions for making the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Bread) { instructions.Add("hold bread"); }

                return instructions;
            }
        }

        public override string ToString()
        {
            return "Pecos Pulled Pork";
        }

    }
}
