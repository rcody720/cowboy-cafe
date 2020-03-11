/*

* Author: Nathan Bean

* Edited By: Cody Reeves 

* Class name: Side.cs

* Purpose: A base class representing the sides
*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a side
    /// </summary>
    public abstract class Side : IOrderItem, INotifyPropertyChanged
    {

        /// <summary>
        /// The property changed event handler
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        private Size size;
        /// <summary>
        /// Gets the size of the entree
        /// </summary>
        public virtual Size Size 
        {
            get
            {
                return size;
            }
            set
            {
                size = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Price"));
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Calories"));
            }
        }

        /// <summary>
        /// Gets the price of the side
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the entree
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions for cooking
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets if the size is small
        /// </summary>
        public virtual bool IsSmall
        {
            get
            {
                if (Size == Size.Small)
                {
                    return true;
                }
                return false;
            }

        }

        /// <summary>
        /// Gets if the size is medium
        /// </summary>
        public virtual bool IsMedium
        {
            get
            {
                if (Size == Size.Medium)
                {
                    return true;
                }
                return false;
            }

        }

        /// <summary>
        /// Gets if the size is large
        /// </summary>
        public virtual bool IsLarge
        {
            get
            {
                if (Size == Size.Large)
                {
                    return true;
                }
                return false;
            }

        }
    }
}
