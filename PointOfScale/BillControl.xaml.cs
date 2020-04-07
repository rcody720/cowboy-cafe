/*

* Author: Cody Reeves

* Class name: BillControl.xaml.cs

* Purpose: The back-end of the Bill control screen

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
using CashRegister;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for CoinControl.xaml
    /// </summary>
    public partial class BillControl : UserControl
    {

        /// <summary>
        /// The DependencyProperty for the DenominationProperty
        /// </summary>
        public static readonly DependencyProperty DenominationProperty = DependencyProperty.Register("Denomination", typeof(Bills), typeof(BillControl), new PropertyMetadata(Bills.One));

        /// <summary>
        /// The Denomination this control displays and modifies
        /// </summary>
        public Bills Denomination
        {
            get { return (Bills)GetValue(DenominationProperty); }
            set { SetValue(DenominationProperty, value); }
        }

        /// <summary>
        /// The DependencyProperty for Quantity
        /// </summary>
        public static readonly DependencyProperty QuantityProperty = DependencyProperty.Register("Quantity", typeof(int), typeof(BillControl), new FrameworkPropertyMetadata(0, FrameworkPropertyMetadataOptions.BindsTwoWayByDefault));

        /// <summary>
        /// Gets or sets the quantity of coin
        /// </summary>
        public int Quantity
        {
            get => (int)GetValue(QuantityProperty);
            set => SetValue(QuantityProperty, value);
        }

        public BillControl()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Handles when the increase button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnIncreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity++;
        }

        /// <summary>
        /// Handles when the decrease button is clicked
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnDecreaseClicked(object sender, RoutedEventArgs e)
        {
            Quantity--;
        }
    }
}