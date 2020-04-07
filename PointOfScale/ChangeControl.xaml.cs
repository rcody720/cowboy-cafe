/*

* Author: Cody Reeves

* Class name: ChangeControl.xaml.cs

* Purpose: The back-end of the change control screen

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
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for ChangeControl.xaml
    /// </summary>
    public partial class ChangeControl : UserControl
    {
        
        /// <summary>
        /// The constructor
        /// </summary>
        public ChangeControl()
        {
            InitializeComponent();                       
        }

        /// <summary>
        /// The constructor with one parameter
        /// </summary>
        /// <param name="crmv">The cash register model view</param>
        public ChangeControl(CashRegisterModelView crmv)
        {
            InitializeComponent();
            DataContext = crmv;
        }

        /// <summary>
        /// Handles when the done button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDoneButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.Page.Child = new OrderControl();        
        }
    }
}
