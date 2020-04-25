/*

* Author: Cody Reeves

* Class name: IOrderItem.cs

* Purpose: An interface to represent an ordered item

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// An interface representing a single item in an order
    /// </summary>
    public interface IOrderItem
    {
        /// <summary>
        /// The price of the item
        /// </summary>
        double Price { get; }

        /// <summary>
        /// The calories of the item
        /// </summary>
        uint Calories { get; }

        //The special instructions for this order item
        List<string> SpecialInstructions { get; }
    }
}
