/*

* Author: Cody Reeves

* Class name: OrderControl.xaml.cs

* Purpose: A class that controls the backend of the user interface

*/

using CowboyCafe.Data;
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
using CashRegister;


namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for OrderControl.xaml
    /// </summary>
    public partial class OrderControl : UserControl
    {

        /// <summary>
        /// The drawer that contains all the money
        /// </summary>
        static CashDrawer drawer = new CashDrawer();

        /// <summary>
        /// Initializes the components and and assigns click event handler
        /// </summary>
        public OrderControl()
        {
            InitializeComponent();
            ItemSelectionButton.Click += OnItemSelectionButtonClicked;
            CancelOrderButton.Click += OnCancelOrderButtonClicked;
            CompleteOrderButton.Click += OnCompleteOrderButtonClicked;
            DataContext = new Order();            
        }

        /// <summary>
        /// Click event handler for Item Selection Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnItemSelectionButtonClicked(object sender, RoutedEventArgs e)
        {
            SwapScreen(new MenuItemSelectionControl());
        }

        /// <summary>
        /// Click event handler for Cancel Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCancelOrderButtonClicked(object sender, RoutedEventArgs e)
        {           
            this.DataContext = new Order();
            
        }

        /// <summary>
        /// Click event handler for Complete Order Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        void OnCompleteOrderButtonClicked(object sender, RoutedEventArgs e)
        {
            Page.Child = new TransactionControl(drawer);
        }    

        /// <summary>
        /// Swaps the screens in the container
        /// </summary>
        /// <param name="element">Screen to be switched to</param>
        public void SwapScreen(UIElement element)
        {
            Container.Child = element;
        }
    }
}
