/*

* Author: Cody Reeves

* Class name: Menu.cs

* Purpose: A class representing the menu

*/

using System;
using System.Collections.Generic;
using System.Linq;
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

        /// <summary>
        /// Searches for order items with the matching terms
        /// </summary>
        /// <param name="items">Order items</param>
        /// <param name="terms">Search terms</param>
        /// <returns>List of items that match the search terms</returns>
        public static IEnumerable<IOrderItem> Search(IEnumerable<IOrderItem> items, string terms)
        {
            List<IOrderItem> results = new List<IOrderItem>();

            if (terms == null) return CompleteMenu();

            foreach(IOrderItem item in items)
            {
               if (item.ToString().Contains(terms, StringComparison.InvariantCultureIgnoreCase))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters the menu items by the desired categories
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="categories">desired categories</param>
        /// <returns>List of items that match the categories</returns>
        public static IEnumerable<IOrderItem> FilterByCategory(IEnumerable<IOrderItem> items, IEnumerable<string> categories)
        {
            if (categories == null || categories.Count() == 0) return items;

            List<IOrderItem> results = new List<IOrderItem>();
            
            foreach(IOrderItem item in items)
            {
                //If statement might not be right
                if (categories.Contains(item.GetType().BaseType.Name))
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by the desired calories
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="min">The minimum calories</param>
        /// <param name="max">The maximum calories</param>
        /// <returns>List of items that match the calories</returns>
        public static IEnumerable<IOrderItem> FilterByCalories(IEnumerable<IOrderItem> items, int? min, int? max)
        {
            if (min == null && max == null) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            if(min == null)
            {
                foreach(IOrderItem item in items)
                {
                    if (item.Calories <= max) results.Add(item);
                }
                return results;
            }

            if(max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Calories >= min) results.Add(item);
                }
                return results;
            }

            foreach(IOrderItem item in items)
            {
                if(item.Calories >= min && item.Calories <= max)
                {
                    results.Add(item);
                }
            }
            return results;
        }

        /// <summary>
        /// Filters by the desired price
        /// </summary>
        /// <param name="items">The menu items</param>
        /// <param name="min">Minimum price</param>
        /// <param name="max">Maximum price</param>
        /// <returns>List of items that match the price</returns>
        public static IEnumerable<IOrderItem> FilterByPrice(IEnumerable<IOrderItem> items, double? min, double? max)
        {
            if (min == null && max == null) return items;

            List<IOrderItem> results = new List<IOrderItem>();

            if (min == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price <= max) results.Add(item);
                }
                return results;
            }

            if (max == null)
            {
                foreach (IOrderItem item in items)
                {
                    if (item.Price >= min) results.Add(item);
                }
                return results;
            }

            foreach (IOrderItem item in items)
            {
                if (item.Price >= min && item.Price <= max)
                {
                    results.Add(item);
                }
            }
            return results;

        }
    }
}
