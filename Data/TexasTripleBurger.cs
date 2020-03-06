/*

* Author: Cody Reeves

* Class name: TexasTripleBurger.cs

* Purpose: A class representing the Texas Triple Burger entree
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Triple Burger entree
    /// </summary>
    public class TexasTripleBurger : Entree 
    {
        /// <summary>
        /// The Price of the entree
        /// </summary>
        public override double Price
        {
            get { return 6.45; }
        }

        /// <summary>
        /// The calories of the entree
        /// </summary>
        public override uint Calories
        {
            get { return 698; }
        }

        private bool bun = true;
        /// <summary>
        /// If the entree should be served with a bun
        /// </summary>
        public bool Bun
        {
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

        private bool tomato = true;
        /// <summary>
        /// If the entree should be served with tomato
        /// </summary>
        public bool Tomato
        {
            get { return tomato; }
            set
            {
                tomato = value;
                NotifyOfPropertyChange("Tomato");
            }
        }

        private bool lettuce = true;
        /// <summary>
        /// If the entree should be served with lettuce
        /// </summary>
        public bool Lettuce
        {
            get { return lettuce; }
            set
            {
                lettuce = value;
                NotifyOfPropertyChange("Lettuce");
            }
        }

        private bool mayo = true;
        /// <summary>
        /// If the entree should be served with Mayo
        /// </summary>
        public bool Mayo
        {
            get { return mayo; }
            set
            {
                mayo = value;
                NotifyOfPropertyChange("Mayo");
            }
        }

        private bool bacon = true;
        /// <summary>
        ///  If the entree should be served with Bacon
        /// </summary>
        public bool Bacon
        {
            get { return bacon; }
            set
            {
                bacon = value;
                NotifyOfPropertyChange("Bacon");
            }
        }

        private bool egg = true;
        /// <summary>
        ///  If the entree should be served with Egg
        /// </summary>
        public bool Egg
        {
            get { return egg; }
            set
            {
                egg = value;
                NotifyOfPropertyChange("Egg");
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
                if (!Tomato) { instructions.Add("hold tomato"); }
                if (!Lettuce) { instructions.Add("hold lettuce"); }
                if (!Mayo) { instructions.Add("hold mayo"); }
                if (!Bacon) { instructions.Add("hold bacon"); }
                if (!Egg) { instructions.Add("hold egg"); }
                
                return instructions;
            }
        }

        /// <summary>
        /// Creates a readable string
        /// </summary>
        /// <returns>The formatted string</returns>
        public override string ToString()
        {
            return "Texas Triple Burger";
        }
    }
}
