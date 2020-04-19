/*

* Author: Cody Reeves

* Class name: Menu.cs

* Purpose: A class representing the menu

*/

using System;
using System.Collections.Generic;
using System.Text;

namespace CowboyCafe.Data
{
    /// <summary>
    /// A class representing the menu
    /// </summary>
    public static class Menu
    {
        /// <summary>
        /// Creates a list of all the entrees offered
        /// </summary>
        /// <returns>The list of entrees</returns>
        public static IEnumerable<IOrderItem> Entrees()
        {
            List<IOrderItem> entrees = new List<IOrderItem>();

            entrees.Add(new AngryChicken());
            entrees.Add(new CowpokeChili());
            entrees.Add(new DakotaDoubleBurger());
            entrees.Add(new PecosPulledPork());
            entrees.Add(new RustlersRibs());
            entrees.Add(new TexasTripleBurger());
            entrees.Add(new TrailBurger());

            return entrees;
        }

        /// <summary>
        /// Creats a list of all the sides offered
        /// </summary>
        /// <returns>The list of sides</returns>
        public static IEnumerable<IOrderItem> Sides()
        {
            List<IOrderItem> sides = new List<IOrderItem>();

            sides.Add(new BakedBeans());
            sides.Add(new ChiliCheeseFries());
            sides.Add(new CornDodgers());
            sides.Add(new PanDeCampo());

            return sides;
        }

        /// <summary>
        /// Creates a list of all the drinks offered
        /// </summary>
        /// <returns>The list of drinks</returns>
        public static IEnumerable<IOrderItem> Drinks()
        {
            List<IOrderItem> drinks = new List<IOrderItem>();

            drinks.Add(new CowboyCoffee());
            drinks.Add(new JerkedSoda());
            drinks.Add(new TexasTea());
            drinks.Add(new Water());

            return drinks;
        }

        /// <summary>
        /// Creates a list of everything on the menu
        /// </summary>
        /// <returns>The list of all items</returns>
        public static IEnumerable<IOrderItem> CompleteMenu()
        {
            List<IOrderItem> menu = new List<IOrderItem>();

            menu.Add(new AngryChicken());
            menu.Add(new CowpokeChili());
            menu.Add(new DakotaDoubleBurger());
            menu.Add(new PecosPulledPork());
            menu.Add(new RustlersRibs());
            menu.Add(new TexasTripleBurger());
            menu.Add(new TrailBurger());
            menu.Add(new BakedBeans());
            menu.Add(new ChiliCheeseFries());
            menu.Add(new CornDodgers());
            menu.Add(new PanDeCampo());
            menu.Add(new CowboyCoffee());
            menu.Add(new JerkedSoda());
            menu.Add(new TexasTea());
            menu.Add(new Water());

            return menu;
        }
    }
}
