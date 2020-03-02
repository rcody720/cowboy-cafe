/*
* Author: Cody Reeves
*
* Class name: MainWindow.xaml.cs
*
* Purpose: A class that controls the backend of the user interface
*/

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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

namespace PointOfSale
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        /// <summary>
        /// Initializes components and the Data Context
        /// <summary>
        public MainWindow()
        {
            InitializeComponent();
            this.DataContext = new Order();
        }
    }
}
