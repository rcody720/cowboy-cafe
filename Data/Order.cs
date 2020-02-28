using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order : INotifyPropertyChanged
    {
        private uint lastOrderNumber;

        private List<IOrderItem> items = new List<IOrderItem>();

        public IEnumerable<IOrderItem> Items => items.ToArray();

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

        public uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item)
        {
            items.Add(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));

        }

        public void Remove(IOrderItem item)
        {
            items.Remove(item);
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Items"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Subtotal"));
        }
    }
}
