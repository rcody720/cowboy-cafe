/*

* Author: Cody Reeves

* Class name: MenuTests.cs

* Purpose: Tests for the Menu class

*/

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;
using NUnit.Framework;
using Assert = Xunit.Assert;

namespace CowboyCafe.DataTests
{
    /// <summary>
    /// Tests for the Menu class
    /// </summary>
    public class MenuTests
    {
        /// <summary>
        /// Entrees method should contain an instance of all the entrees on the menu
        /// </summary>
        [Fact]
        public void MenuEntreesShouldContainExpectedEntrees()
        {
            Assert.Collection(
                Menu.Entrees(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        /// <summary>
        /// Sides method should contain an instance of all the sides on the menu
        /// </summary>
        [Fact]
        public void MenuSidesShouldContainExpectedSides()
        {
            Assert.Collection(
                Menu.Sides(),
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },                
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); }
                );
        }

        /// <summary>
        /// Drinks method should contain an instance of all the drinks on the menu
        /// </summary>
        [Fact]
        public void MenuDrinksShouldContainExpectedDrinks()
        {
            Assert.Collection(
                Menu.Drinks(),
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Complete menu method should contain an instance of all the items on the menu
        /// </summary>
        [Fact]
        public void MenuCompleteMenuShouldContainAllMenuItems()
        {
            Assert.Collection(
                Menu.CompleteMenu(),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Search method should return the items that contain the searched for terms
        /// </summary>
        [Fact]
        public void SearchShouldReturnSearchedTerm()
        {      
            Assert.Collection(
                Menu.Search(Menu.CompleteMenu(), "Chicken"),
                (ac) => { Assert.IsType<AngryChicken>(ac); }
                );
        }

        /// <summary>
        /// Search method should return all items if there are no search terms
        /// </summary>
        [Fact]
        public void NullSearchShouldReturnCompleteMenu()
        {
            Assert.Collection(
                Menu.Search(Menu.CompleteMenu(), null),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); },
                (bb) => { Assert.IsType<BakedBeans>(bb); },
                (ccf) => { Assert.IsType<ChiliCheeseFries>(ccf); },
                (cd) => { Assert.IsType<CornDodgers>(cd); },
                (pdc) => { Assert.IsType<PanDeCampo>(pdc); },
                (cc) => { Assert.IsType<CowboyCoffee>(cc); },
                (js) => { Assert.IsType<JerkedSoda>(js); },
                (tt) => { Assert.IsType<TexasTea>(tt); },
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Filter by Category should return the items in the desired category
        /// </summary>
        [Fact]
        public void FilterByCategoryShouldReturnItemsFromDesiredCategory()
        {
            var category = new List<string>() { "Entree" };            
            Assert.Collection(
                Menu.FilterByCategory(Menu.CompleteMenu(), category),
                (ac) => { Assert.IsType<AngryChicken>(ac); },
                (cc) => { Assert.IsType<CowpokeChili>(cc); },
                (ddb) => { Assert.IsType<DakotaDoubleBurger>(ddb); },
                (ppp) => { Assert.IsType<PecosPulledPork>(ppp); },
                (rr) => { Assert.IsType<RustlersRibs>(rr); },
                (ttb) => { Assert.IsType<TexasTripleBurger>(ttb); },
                (tb) => { Assert.IsType<TrailBurger>(tb); }
                );
        }

        /// <summary>
        /// Filter by Category should return all the items if there is no desired category
        /// </summary>
        [Fact]
        public void FilterByCategoryShouldReturnAllItemsWhenNull()
        {
            List<string> category = null;
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByCategory(items, category));
        }

        /// <summary>
        /// Filter by Calories should return the items within the desired calorie bounds
        /// </summary>
        [Fact]
        public void FilterByCaloriesShouldReturnItemsWithDesiredCalories()
        {
            Assert.Collection(
                Menu.FilterByCalories(Menu.CompleteMenu(), 10, 100),
                (tt) => { Assert.IsType<TexasTea>(tt); }
                );
        }

        /// <summary>
        /// Filter by Calories should return the items above the minimum calories entered
        /// </summary>
        [Fact]
        public void FilterByCaloriesWithOnlyMinShouldReturnItemsWithDesiredCalories()
        {
            Assert.Collection(
                Menu.FilterByCalories(Menu.CompleteMenu(), 800, null),
                (rr) => { Assert.IsType<RustlersRibs>(rr); }
                );
        }

        /// <summary>
        /// Filter by Calories should return the items below the maximum calories entered
        /// </summary>
        [Fact]
        public void FilterByCaloriesWithOnlyMaxShouldReturnItemsWithDesiredCalories()
        {
            Assert.Collection(
                Menu.FilterByCalories(Menu.CompleteMenu(), null, 0),
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Filter by Calories should return all the items when no calorie bounds are entered
        /// </summary>
        [Fact]
        public void FilterByCaloriesShouldReturnAllItemsWhenNull()
        {
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByCalories(items, null, null));
        }

        /// <summary>
        /// Filter by Price should return the items within the entered price bounds
        /// </summary>
        [Fact]
        public void FilterByPriceShouldReturnItemsWithDesiredPrice()
        {
            Assert.Collection(
                Menu.FilterByPrice(Menu.CompleteMenu(), 7, 8),
                (rr) => { Assert.IsType<RustlersRibs>(rr); }
                );
        }

        /// <summary>
        /// Filter by Price should return the items above the minimum price entered
        /// </summary>
        [Fact]
        public void FilterByPriceWithOnlyMinShouldReturnItemsWithDesiredPrice()
        {
            Assert.Collection(
                Menu.FilterByPrice(Menu.CompleteMenu(), 7, null),
                (rr) => { Assert.IsType<RustlersRibs>(rr); }
                );
        }

        /// <summary>
        /// Filter by Price should return the items below the maximum price entered 
        /// </summary>
        [Fact]
        public void FilterByPriceWithOnlyMaxShouldReturnItemsWithDesiredPrice()
        {
            Assert.Collection(
                Menu.FilterByPrice(Menu.CompleteMenu(), null, .5),
                (w) => { Assert.IsType<Water>(w); }
                );
        }

        /// <summary>
        /// Filter by Price should return all the items when no price bounds are entered
        /// </summary>
        [Fact]
        public void FilterByPriceShouldReturnAllItemsWhenNull()
        {
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByPrice(items, null, null));
        }
    }
}
