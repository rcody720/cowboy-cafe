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
    public interface IOrderItem
    {
        /// <summary>
        /// An interface representing a single item in an order
        /// </summary>
        double Price { get; }

        //The special instructions for this order item
        List<string> SpecialInstructions { get; }
    }
}
