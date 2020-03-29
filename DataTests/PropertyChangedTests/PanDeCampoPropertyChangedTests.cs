/*

* Author: Cody Reeves

* Class name: PanDeCampoPropertyChangedTests.cs

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
    public class PanDeCampoPropertyChangedTests
    {
        //Test 1: Pan de Campo should implement the INotifyPropertyChanged Interface
        [Fact]
        public void PanDeCampoShouldImplementINotifyPropertyChanged()
        {
            var campo = new PanDeCampo();
            Assert.IsAssignableFrom<INotifyPropertyChanged>(campo);
        }

        //Test 2: Changing the "Size" property should invoke PropertyChanged for "Size"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForSize()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Size", () =>
            {
                campo.Size = Size.Medium;
            });
        }

        //Test 3: Changing the "Size" property should invoke PropertyChanged for "Price"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForPrice()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Price", () =>
            {
                campo.Size = Size.Medium;
            });
        }

        //Test 4: Changing the "Size" property should invoke PropertyChanged for "Calories"
        [Fact]
        public void ChangingSizeShouldInvokePropertyChangedForCalories()
        {
            var campo = new PanDeCampo();
            Assert.PropertyChanged(campo, "Calories", () =>
            {
                campo.Size = Size.Medium;
            });
        }
    }
}
