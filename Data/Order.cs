using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    public class Order
    {
        public IEnumerable<IOrderItem> Items => throw new NotImplementedException();

        public double Subtotal => 0;

        public void Add(IOrderItem item) { }

        public void Remove(IOrderItem item) { }
    }
}
