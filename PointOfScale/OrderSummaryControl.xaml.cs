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

        /// <summary>
        /// Allows the user to return to the special instructions screen for a selected item in the order
        /// </summary>
        /// <param name="sender">The item selected</param>
        /// <param name="e">The items in the listbox</param>
        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            var orderControl = this.FindAncestor<OrderControl>();
            
            foreach(object item in e.AddedItems)
            {                
                if (item is AngryChicken)
                {
                    var screen = new CustomizeAngryChicken();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is CowpokeChili)
                {
                    var screen = new CustomizeCowpokeChili();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is DakotaDoubleBurger)
                {
                    var screen = new CustomizeDakotaDoubleBurger();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is PecosPulledPork)
                {
                    var screen = new CustomizePecosPulledPork();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is TexasTripleBurger)
                {
                    var screen = new CustomizeTexasTripleBurger();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is TrailBurger)
                {
                    var screen = new CustomizeTrailBurger();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is BakedBeans)
                {
                    var screen = new CustomizeBakedBeans();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is ChiliCheeseFries)
                {
                    var screen = new CustomizeChiliCheeseFries();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is CornDodgers)
                {
                    var screen = new CustomizeCornDodgers();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is PanDeCampo)
                {
                    var screen = new CustomizePanDeCampo();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is CowboyCoffee)
                {
                    var screen = new CustomizeCowboyCoffee();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is JerkedSoda)
                {
                    var screen = new CustomizeJerkedSoda();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);                        
                }
                else if (item is TexasTea)
                {
                    var screen = new CustomizeTexasTea();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
                else if (item is Water)
                {
                    var screen = new CustomizeWater();
                    screen.DataContext = item;
                    orderControl.SwapScreen(screen);
                }
            }
        }

        /// <summary>
        /// Deletes the item from the order
        /// </summary>
        /// <param name="sender">the button clicked</param>
        /// <param name="e"></param>
        private void OnDeleteButtonClick(object sender, RoutedEventArgs e)
        {
            if(DataContext is Order data)
            {
                if(sender is Button button)
                {
                    data.Remove((IOrderItem)button.DataContext);
                }                
            }
        }
    }
}
