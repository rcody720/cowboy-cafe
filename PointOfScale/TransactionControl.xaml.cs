﻿/*

* Author: Cody Reeves

* Class name: TransactionContorl.xaml.cs

* Purpose: The back-end of the Transaction control

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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for TransactionControl.xaml
    /// </summary>
    public partial class TransactionControl : UserControl
    {

        CashDrawer drawer;
        /// <summary>
        ///The Constructor
        /// </summary>
        public TransactionControl()
        {
            InitializeComponent();                       
        }

        /// <summary>
        /// The constructor with one parameter
        /// </summary>
        /// <param name="cd"></param>
        public TransactionControl(CashDrawer cd)
        {
            InitializeComponent();
            drawer = cd;
        }

        /// <summary>
        /// Handles when the cash button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                ButtonArea.Child = new CashDrawerControl(drawer, data);
                
                ReceiptPrinting(data, false);
            }
            
        }

        /// <summary>
        /// Handles when the credit card button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            var cardTerminal = new CardTerminal();

            if (DataContext is Order data)
            {
                ResultCode result = cardTerminal.ProcessTransaction(data.Total);

                if (result == ResultCode.Success)
                {
                    ReceiptPrinting(data, true);
                }
                else
                {
                    MessageBox.Show(result.ToString());
                }
            }

        }

        /// <summary>
        /// Handles when the cancel button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {        
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.Page.Child = new OrderControl();
        }

        /// <summary>
        /// Helper method to construct the string for the receipt
        /// </summary>
        /// <param name="data">The Order</param>
        private void ReceiptPrinting(Order data, bool credit)
        {
            var receiptPrinter = new ReceiptPrinter();
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order: " + data.OrderNumber.ToString());
            sb.AppendLine(DateTime.Now.ToString());

            foreach (IOrderItem item in data.Items)
            {
                sb.AppendLine(item.ToString());
                if (item.SpecialInstructions != null)
                {
                    foreach (string details in item.SpecialInstructions)
                    {
                        sb.AppendLine(details);
                    }
                }

            }

            sb.AppendLine("Subtotal: " + String.Format("{0:C2}", data.Subtotal));
            sb.AppendLine("Total: " + String.Format("{0:C2}", data.Total));
            if (credit)
            {
                sb.AppendLine("Paid with Credit");
            }
            else
            {
                 sb.AppendLine("Paid with Cash");
            }            
            receiptPrinter.Print(sb.ToString());
        }
    }
}
