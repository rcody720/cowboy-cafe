﻿/*

* Author: Cody Reeves

* Class name: Entree.cs

* Purpose: A base class representing the entrees
*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing the entrees
    /// </summary>
    public abstract class Entree
    {
        /// <summary>
        /// Gets the price of the entree
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }
    }
}
