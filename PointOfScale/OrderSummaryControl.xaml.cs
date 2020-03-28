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

        private void ListBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        { 
            var orderControl = this.FindAncestor<OrderControl>();
            
            foreach(object item in e.AddedItems)
            {
                if (item is AngryChicken)
                {                   
                    orderControl.SwapScreen(new CustomizeAngryChicken());
                }
                else if (item is CowpokeChili)
                {
                    orderControl.SwapScreen(new CustomizeCowpokeChili());
                }
                else if (item is DakotaDoubleBurger)
                {
                    orderControl.SwapScreen(new CustomizeDakotaDoubleBurger());
                }
                else if (item is PecosPulledPork)
                {
                    orderControl.SwapScreen(new CustomizePecosPulledPork());
                }
                else if (item is TexasTripleBurger)
                {
                    orderControl.SwapScreen(new CustomizeTexasTripleBurger());
                }
                else if (item is TrailBurger)
                {
                    orderControl.SwapScreen(new CustomizeTrailBurger());
                }
                else if (item is BakedBeans)
                {
                    orderControl.SwapScreen(new CustomizeBakedBeans());
                }
                else if (item is ChiliCheeseFries)
                {
                    orderControl.SwapScreen(new CustomizeChiliCheeseFries());
                }
                else if (item is CornDodgers)
                {
                    orderControl.SwapScreen(new CustomizeCornDodgers());
                }
                else if (item is PanDeCampo)
                {
                    orderControl.SwapScreen(new CustomizePanDeCampo());
                }
                else if (item is CowboyCoffee)
                {
                    orderControl.SwapScreen(new CustomizeCowboyCoffee());
                }
                else if (item is JerkedSoda)
                {
                    orderControl.SwapScreen(new CustomizeJerkedSoda());                        
                }
                else if (item is TexasTea)
                {
                    orderControl.SwapScreen(new CustomizeTexasTea());
                }
                else if (item is Water)
                {
                    orderControl.SwapScreen(new CustomizeWater());
                }
            }
        }
    }
}
