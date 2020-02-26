using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order
    {
        private uint lastOrderNumber;

        private List<IOrderItem> items;

        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public double Subtotal => 0;

        public uint OrderNumber { get; }

        public event PropertyChangedEventHandler PropertyChanged;

        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }
    }
}
