/*

* Author: Cody Reeves

* Class name: Trailburger.cs

* Purpose: A class representing the Trail Burger entree

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the TrailBurger entree
    /// </summary>
    public class TrailBurger : Entree
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get { return 4.50; }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get { return 288; }
        }

        private bool bun = true;
        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Bun{

            get { return bun; }
            set
            {
                bun = value;
                NotifyOfPropertyChange("Bun");
}
        }

        private bool ketchup = true;
        /// <summary>
        /// If the entree should be served with Ketchup
        /// </summary>
        public bool Ketchup
        {
            get { return ketchup; }
            set
            {
                ketchup = value;
                NotifyOfPropertyChange("Ketchup");
            }
        }

        private bool mustard = true;
        /// <summary>
        /// If the entree should be served with Mustard
        /// </summary>
        public bool Mustard
        {
            get { return mustard; }
            set
            {
                mustard = value;
                NotifyOfPropertyChange("Mustard");
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the entree should be served with Pickles
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set
            {
                pickle = value;
                NotifyOfPropertyChange("Pickle");
            }
        }

        private bool cheese = true;
        /// <summary>
        /// If the entree should be served with cheese
        /// </summary>
        public bool Cheese
        {
            get { return cheese; }
            set
            {
                cheese = value;
                NotifyOfPropertyChange("Cheese");
            }
        }
        /// <summary>
        /// The special instructions for making the entree
        /// </summary>
        public override List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Bun) { instructions.Add("hold bun"); }
                if (!Ketchup) { instructions.Add("hold ketchup"); }
                if (!Mustard) { instructions.Add("hold mustard"); }
                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Cheese) { instructions.Add("hold cheese"); }

                return instructions;
            }
        }

        /// <summary>
        /// Creates a readable string
        /// </summary>
        /// <returns>The formatted string</returns>
        public override string ToString()
        {
            return "Trail Burger";
        }
    }
}
