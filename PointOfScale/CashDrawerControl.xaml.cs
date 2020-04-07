/*

* Author: Cody Reeves

* Class name: CashDrawerControl.xaml.cs

* Purpose: The back-end of the Cash Drawer Control

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
using CashRegister;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CashDrawerControl.xaml
    /// </summary>
    public partial class CashDrawerControl : UserControl
    {

        CashRegisterModelView crmv;

        public CashDrawerControl()
        {
            InitializeComponent();               
        }

        /// <summary>
        /// A constructor that takes in 2 parameters
        /// </summary>
        /// <param name="cd">The cash drawer</param>
        /// <param name="ord">The order</param>
        public CashDrawerControl(CashDrawer cd, Order ord)
        {
            crmv = new CashRegisterModelView(cd, ord);
            DataContext = crmv;
            InitializeComponent();
        }

        /// <summary>
        /// Handles when the done button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnDoneButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is CashRegisterModelView data)
            {
               
               if(data.Payment < data.TotalCost)
                {
                    MessageBox.Show("Insufficient Payment. Add More");
                }
                else
                {
                    double change = data.Payment - data.TotalCost;
                    var orderControl = this.FindAncestor<OrderControl>();
                    orderControl.Page.Child = new ChangeControl(crmv);
                }
            }
            
        }

    }
}
