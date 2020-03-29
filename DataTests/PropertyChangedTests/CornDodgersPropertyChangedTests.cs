/*

* Author: Cody Reeves

* Class name: CornDodgersPropertyChangedTests.cs

* Purpose: Tests for the Property Changes

*/

using System;
using System.Collections.Generic;
using System.Text;
using Xunit;
using System.ComponentModel;
using CowboyCafe.Data;

namespace CowboyCafe.DataTests.PropertyChangedTests
{
    public class CornDodgersPropertyChangedTests
    {
        //Test 1: Corn Dodgers should implement the INotifyPropertyChanged Interface
        [Fact]
        public void CornDodgersShouldImplementINotifyPropertyChanged()
        {
            var dodgers = new CornDodgers();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(dodgers);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Size", () =>
            {
                dodgers.Size = Size.Medium;
            });
        }

        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Price", () =>
            {
                dodgers.Size = Size.Medium;
            });
        }

        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var dodgers = new CornDodgers();
            Assert.PropertyChanged(dodgers, "Calories", () =>
            {
                dodgers.Size = Size.Medium;
            });
        }
    }
}
