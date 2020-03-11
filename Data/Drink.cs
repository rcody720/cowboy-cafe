/*

* Author: Cody Reeves

* Class name: Drink.cs

* Purpose: A base class representing the drinks

*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A base class representing a drink
    /// </summary>
    public abstract class Drink : IOrderItem, INotifyPropertyChanged
    {
        /// <summary>
        /// The property changed event
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Gets the Price of the drink
        /// </summary>
        public abstract double Price { get; }

        /// <summary>
        /// Gets the calories of the drink
        /// </summary>
        public abstract uint Calories { get; }

        /// <summary>
        /// Gets the special instructions 
        /// </summary>
        public abstract List<string> SpecialInstructions { get; }

        /// <summary>
        /// Gets the size of the drink
        /// </summary>
        public virtual Size Size { get; set; } = Size.Small;

        private bool ice = true;
        /// <summary>
        /// Gets if the drink has ice
        /// </summary>
        public virtual bool Ice
        {
            get
            {
                return ice;
            }
            set
            {
                ice = value;
                NotifyOfPropertyChange();
            }
        }

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
            set
            {
                if (value)
                {
                    Size = Size.Small;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
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
            set
            {
                if (value)
                {
                    Size = Size.Medium;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
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
            set
            {
                if (value)
                {
                    Size = Size.Large;
                    PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Size"));
                }
            }
            
        }

        /// <summary>
        /// Helper method to notify of boolean property customization property changes
        /// </summary>
        /// <param name="propertyName"></param>
        protected void NotifyOfPropertyChange()
        {            
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("SpecialInstructions"));
        }

        /// <summary>
        /// Helper method to notify of boolean property customization property changes
        /// </summary>
        protected void NotifyOfFlavorChange()
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Flavor"));
        }

    }
}
