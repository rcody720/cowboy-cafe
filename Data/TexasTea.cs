﻿/*

* Author: Cody Reeves

* Class name: TexasTea.cs

* Purpose: A class representing the Texas Tea drink

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the Texas Tea drink
    /// </summary>
    public class TexasTea : Drink
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
                        return 1.00;
                    case Size.Medium:
                        return 1.50;
                    case Size.Large:
                        return 2.00;
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
                if (Sweet)
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 10;
                        case Size.Medium:
                            return 22;
                        case Size.Large:
                            return 36;
                        default:
                            throw new NotImplementedException();
                    }
                }
                else
                {
                    switch (Size)
                    {
                        case Size.Small:
                            return 5;
                        case Size.Medium:
                            return 11;
                        case Size.Large:
                            return 18;
                        default:
                            throw new NotImplementedException();
                    }
                }
            }
        }

        private bool sweet = true;
        /// <summary>
        /// Gets if it is sweet 
        /// </summary>
        public bool Sweet
        {
            get
            {
                return sweet;
            }
            set
            {
                sweet = value;
                NotifyOfPropertyChange("Sweet");
            }
        }

        private bool lemon = false;
        /// <summary>
        /// Gets if there is Lemon
        /// </summary>
        public bool Lemon
        {
            get
            {
                return lemon;
            }
            set
            {
                lemon = value;
                NotifyOfPropertyChange("Lemon");
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

                if (Lemon) { instructions.Add("Add Lemon"); }
                if (!Ice) { instructions.Add("Hold Ice"); }
                return instructions;
            }
        }

        /// <summary>
        /// Creates a readable string
        /// </summary>
        /// <returns>The formatted string</returns>
        public override string ToString()
        {
            if (Sweet)
            {
                return $"{Size} Texas Sweet Tea";
            }
            else
            {
                return $"{Size} Texas Plain Tea";
            }
            
        }
    }
}
