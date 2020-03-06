/*

* Author: Cody Reeves

* Class name: Order.cs

* Purpose: A class that represents a person's order

*/

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class that represents a person's order
    /// </summary>
    public class Order : INotifyPropertyChanged
    {
        /// <summary>
        /// Holds the last order's number
        /// </summary>
        private static uint lastOrderNumber;

        /// <summary>
        /// A list of the ordered items
        /// </summary>
        private List<IOrderItem> items = new List<IOrderItem>();

        /// <summary>
        /// An IEnumerable of the items
        /// </summary>
        public IEnumerable<IOrderItem> Items => items.ToArray();

        /// <summary>
        /// Gets the subtotal for the order
        /// </summary>
        public double Subtotal
        {
            get
            {
                double sub = 0;
                foreach(IOrderItem food in items)
                {
                    sub += food.Price;
                }
                return sub;
            }
        }

        /// <summary>
        /// The current order number
        /// </summary>
        public uint OrderNumber => lastOrderNumber++;

        /// <summary>
        /// An event handler for when a property is changed
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// Adds to the list of items
        /// </summary>
        /// <param name="item">The IOrderItem you want to add</param>
        public void Add(IOrderItem item)
        {
            if(item is INotifyPropertyChanged notifier)
            {               
                notifier.PropertyChanged += OnItemPropertyChanged;
            }
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }

        /// <summary>
        /// Removes from the list of items
        /// </summary>
        /// <param name="item">The IOrderItem you want to remove</param>
        public void Remove(IOrderItem item)
        {
            if (item is INotifyPropertyChanged notifier)
            {
                notifier.PropertyChanged -= OnItemPropertyChanged;
            }
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }      
        
        private void OnItemPropertyChanged(object sender, PropertyChangedEventArgs e)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));           
            if(e.PropertyName == "Price")
            {
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
            }
        }
    }
}
