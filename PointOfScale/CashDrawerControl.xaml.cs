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

        public CashDrawerControl(CashDrawer cd, Order ord)
        {
            crmv = new CashRegisterModelView(cd, ord);
            DataContext = crmv;
            InitializeComponent();
        }

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
                    orderControl.Page.Child = new ChangeControl(change, crmv);
                }
            }
            
        }

    }
}
