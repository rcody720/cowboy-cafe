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

        private CashDrawer drawer = new CashDrawer();

        public TransactionControl()
        {
            InitializeComponent();                       
        }

        void OnCashButtonClicked(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                ButtonArea.Child = new CashDrawerControl(drawer, data);
                
                ReceiptPrinting(data);
            }
            
        }

        void OnCreditButtonClicked(object sender, RoutedEventArgs e)
        {
            var cardTerminal = new CardTerminal();

            if (DataContext is Order data)
            {
                ResultCode result = cardTerminal.ProcessTransaction(data.Total);

                if (result == ResultCode.Success)
                {
                    ReceiptPrinting(data);
                }
                else
                {
                    MessageBox.Show(result.ToString());
                }
            }

        }

        void OnCancelButtonClicked(object sender, RoutedEventArgs e)
        {        
            var orderControl = this.FindAncestor<OrderControl>();
            orderControl.Page.Child = new OrderControl();
        }

        private void ReceiptPrinting(Order data)
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
            sb.AppendLine("Paid with Credit");

            receiptPrinter.Print(sb.ToString());
        }
    }
}
