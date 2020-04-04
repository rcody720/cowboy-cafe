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
        public TransactionControl()
        {
            InitializeComponent();
            
        }

        void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            var cardTerminal = new CardTerminal();
            ResultCode result = cardTerminal.ProcessTransaction();
        }

        void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            var cardTerminal = new CardTerminal();
            ResultCode result = cardTerminal.ProcessTransaction();
        }

        void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {        
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.Page.Child = new OrderControl();
        }
    }
}
