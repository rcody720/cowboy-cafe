using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using CowboyCafe.Data;
using System.Linq;

namespace CowboyCafe.DataTests
{
    public class MenuTests
    {

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

        [Fact]
        public void SearchShouldReturnSearchedTerm()
        {
            var terms = "Chicken";
            var items = Menu.CompleteMenu();
            var answer = new List<IOrderItem>() { new AngryChicken() };
            Assert.Equal(answer, Menu.Search(items, terms));
        }

        [Fact]
        public void NullSearchShouldReturnCompleteMenu()
        {
            string terms = null;
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.Search(items, terms));
        }

        [Fact]
        public void FilterByCategoryShouldReturnItemsFromDesiredCategory()
        {
            var category = new List<string>() { "Entree" };
            var items = Menu.CompleteMenu();
            Assert.Equal(Menu.Entrees(), Menu.FilterByCategory(items, category));
        }

        [Fact]
        public void FilterByCategoryShouldReturnAllItemsWhenNull()
        {
            List<string> category = null;
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByCategory(items, category));
        }

        [Fact]
        public void FilterByCaloriesShouldReturnItemsWithDesiredCalories()
        {
            var items = Menu.CompleteMenu();
            var min = 10;
            var max = 100;
            var result = new List<IOrderItem>() { new TexasTea() };
            Assert.Equal(result, Menu.FilterByCalories(items, min, max));
        }

        [Fact]
        public void FilterByCaloriesWithOnlyMinShouldReturnItemsWithDesiredCalories()
        {
            var items = Menu.CompleteMenu();
            var min = 800;
            var result = new List<IOrderItem>() { new RustlersRibs() };
            Assert.Equal(result, Menu.FilterByCalories(items, min, null));
        }

        [Fact]
        public void FilterByCaloriesWithOnlyMaxShouldReturnItemsWithDesiredCalories()
        {
            var items = Menu.CompleteMenu();
            var max = 0;
            var result = new List<IOrderItem>() { new Water() };
            Assert.Equal(result, Menu.FilterByCalories(items, null, max));
        }

        [Fact]
        public void FilterByCaloriesShouldReturnAllItemsWhenNull()
        {
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByCalories(items, null, null));
        }

        [Fact]
        public void FilterByPriceShouldReturnItemsWithDesiredCalories()
        {
            var items = Menu.CompleteMenu();
            var min = 7;
            var max = 8;
            var result = new List<IOrderItem>() { new RustlersRibs() };
            Assert.Equal(result, Menu.FilterByPrice(items, min, max));
        }

        [Fact]
        public void FilterByPriceWithOnlyMinShouldReturnItemsWithDesiredCalories()
        {
            var items = Menu.CompleteMenu();
            var min = 7;
            var result = new List<IOrderItem>() { new RustlersRibs() };
            Assert.Equal(result, Menu.FilterByPrice(items, min, null));
        }

        [Fact]
        public void FilterByPriceWithOnlyMaxShouldReturnItemsWithDesiredCalories()
        {
            var items = Menu.CompleteMenu();
            var max = .5;
            var result = new List<IOrderItem>() { new Water() };
            Assert.Equal(result, Menu.FilterByPrice(items, null, max));
        }

        [Fact]
        public void FilterByPriceShouldReturnAllItemsWhenNull()
        {
            var items = Menu.CompleteMenu();
            Assert.Equal(items, Menu.FilterByPrice(items, null, null));
        }
    }
}
