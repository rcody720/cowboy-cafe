/*

* Author: Cody Reeves

* Class name: MenuItemSelectionControl.xaml.cs

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
using CowboyCafe.Data;
using CowboyCafe.Extensions;

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MenuItemSelectionControl.xaml
    /// </summary>
    public partial class MenuItemSelectionControl : UserControl
    {       
        /// <summary>
        /// Initializes the components and and assigns click event handler
        /// </summary>
        public MenuItemSelectionControl()
        {
            InitializeComponent();
            AddAngryChickenButton.Click += OnAddAngryChickenButtonClicked;
            AddCowpokeChiliButton.Click += OnAddCowpokeChiliButtonClicked;
            AddDakotaDoubleBurgerButton.Click += OnAddDakotaDoubleBurgerButtonClicked;
            AddPecosPulledPorkButton.Click += OnAddPecosPulledPorkButtonClicked;
            AddRustlersRibsButton.Click += OnAddRustlersRibsButtonClicked;
            AddTexasTripleBurgerButton.Click += OnAddTexasTripleBurgerButtonClicked;
            AddTrailBurgerButton.Click += OnAddTrailBurgerButtonClicked;
            AddBakedBeansButton.Click += OnAddBakedBeansButtonClicked;
            AddChiliCheeseFriesButton.Click += OnAddChiliCheeseFriesButtonClicked;
            AddCornDodgersButton.Click += OnAddCornDodgersButtonClicked;
            AddPanDeCampoButton.Click += OnAddPanDeCampoButtonClicked;
            AddCowboyCoffeeButton.Click += OnAddCowboyCoffeeButtonClicked;
            AddJerkedSodaButton.Click += OnAddJerkedSodaButtonClicked;
            AddTexasTeaButton.Click += OnAddTexasTeaButtonClicked;
            AddWaterButton.Click += OnAddWaterButtonClicked;
        }

        /// <summary>
        /// Adds the item to the order and switches to the customization screen if neccessary.
        /// </summary>
        /// <param name="item">The IOrderItem to add</param>
        /// <param name="screen">The customization screen (or null for none)</param>
        void AddItemAndOpenCustomization(IOrderItem item, FrameworkElement screen)
        {
            var order = DataContext as Order;
            if (order == null) throw new Exception("DataContext expected to be an Order instance but was null");

            if (screen != null)
            {
                var orderControl = this.FindAncestor<OrderControl>();
                if (orderControl == null) throw new Exception("An ancestor of OrderControl was not found");

                screen.DataContext = item;
                orderControl.SwapScreen(screen);
            }

            order.Add(item);
        }
 
        /// <summary>
        /// Click event handler for Angry Chicken Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddAngryChickenButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new AngryChicken();
                var screen = new CustomizeAngryChicken();
                AddItemAndOpenCustomization(item, screen);
            }        
        }

        /// <summary>
        /// Click event handler for Cowpoke Chili Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCowpokeChiliButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new CowpokeChili();
                var screen = new CustomizeCowpokeChili();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Dakota Double Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddDakotaDoubleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new DakotaDoubleBurger();
                var screen = new CustomizeDakotaDoubleBurger();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Pecos Pulled Pork Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddPecosPulledPorkButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new PecosPulledPork();
                var screen = new CustomizePecosPulledPork();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Rustler's Ribs Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddRustlersRibsButtonClicked(object sender, RoutedEventArgs e)
        {            
            if (DataContext is Order data)
            {                
                data.Add(new RustlersRibs());               
            }
        }

        /// <summary>
        /// Click event handler for Texas Triple Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTexasTripleBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new TexasTripleBurger();
                var screen = new CustomizeTexasTripleBurger();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Trail Burger Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTrailBurgerButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new TrailBurger();
                var screen = new CustomizeTrailBurger();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Baked Beans Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddBakedBeansButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new BakedBeans());
            }
        }

        /// <summary>
        /// Click event handler for Chili Cheese Fries Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddChiliCheeseFriesButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new ChiliCheeseFries());
            }
        }

        /// <summary>
        /// Click event handler for Corn Dodgers Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCornDodgersButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new CornDodgers());
            }
        }

        /// <summary>
        /// Click event handler for Pan De Campo Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddPanDeCampoButtonClicked(object sender, RoutedEventArgs e)
        {
            if (DataContext is Order data)
            {
                data.Add(new PanDeCampo());
            }
        }

        /// <summary>
        /// Click event handler for Cowboy Coffee Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddCowboyCoffeeButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new CowboyCoffee();
                var screen = new CustomizeCowboyCoffee();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Jerked Soda Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddJerkedSodaButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new JerkedSoda();
                var screen = new CustomizeJerkedSoda();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Texas Tea Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddTexasTeaButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new TexasTea();
                var screen = new CustomizeTexasTea();
                AddItemAndOpenCustomization(item, screen);
            }
        }

        /// <summary>
        /// Click event handler for Water Button
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        public void OnAddWaterButtonClicked(object sender, RoutedEventArgs e)
        {
            var orderControl = this.FindAncestor<OrderControl>();

            if (DataContext is Order data)
            {
                var item = new Water();
                var screen = new CustomizeWater();
                AddItemAndOpenCustomization(item, screen);
            }
        }
    }
}
