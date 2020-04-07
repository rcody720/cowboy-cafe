using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
/*

* Author: Cody Reeves

* Class name: ChangeControl.xaml.cs

* Purpose: The back-end of the change control screen

*/

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

        public double Change;

        public ChangeControl()
        {
            InitializeComponent();                       
        }

        public ChangeControl(double chng, CashRegisterModelView crmv)
        {
            Change = chng;
            InitializeComponent();
            DataContext = crmv;
        }

        void OnDoneButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.Page.Child = new OrderControl();        
        }
    }
}
