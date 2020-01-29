using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Angry Chicken entree
    /// </summary>
    public class AngryChicken
    {
        /// <summary>
        /// The price of the entree
        /// </summary>
        public double Price
        {
            get
            {
                return 5.99;
            }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public uint Calories
        {
            get
            {
                return 190;
            }
        }

        private bool pickle = true;
        /// <summary>
        /// If the entree should be served with a pickle
        /// </summary>
        public bool Pickle
        {
            get { return pickle; }
            set { pickle = value; }
        }

        /// <summary>
        /// If the entree should be served with bread
        /// </summary>
        public bool Bread { get; set; } = true;

        public List<string> SpecialInstructions
        {
            get
            {
                List<string> instructions = new List<string>();

                if (!Pickle) { instructions.Add("hold pickle"); }
                if (!Bread) { instructions.Add("hold bread"); }

                return instructions;
            }
        }
    }
}
