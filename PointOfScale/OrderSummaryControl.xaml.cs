/*

* Author: Cody Reeves

* Class name: OrderSummaryContorl.xaml.cs

* Purpose: A class that controls the backend of the user interface

*/

using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
using CowboyCafe.Extensions;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderSummaryControl.xaml
    /// </summary>
    public partial class OrderSummaryControl : UserControl
    {
        /// <summary>
        /// Constructor that initializes the components
        /// </summary>
        public OrderSummaryControl()
        {
            InitializeComponent();
            
        }

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            var orderControl = this.FindAncestor<OrderControl>();
            if (DataContext is AngryChicken data)
            {
                orderControl.SwapScreen(CustomizeAngryChicken);
            }
        }
    }
}
