/*

* Author: Cody Reeves

* Class name: CashRegisterModelView.cs

* Purpose: The model view for the Cash Register

*/

using System;
using System.Collections.Generic;
using System.Text;
using System.ComponentModel;
using CashRegister;
using CowboyCafe.Data;

namespace PointOfSale
{
    /// <summary>
    /// The model view class for the cash register
    /// </summary>
    public class CashRegisterModelView : INotifyPropertyChanged
    {
        /// <summary>
        /// Notifies of property changed events
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// The CashDrawer this class uses
        /// </summary>
        CashDrawer drawer;

        /// <summary>
        /// The current order 
        /// </summary>
        Order order;

        /// <summary>
        /// Gets The total current value of the drawer
        /// </summary>
        public double TotalValue => drawer.TotalValue;

        /// <summary>
        /// Gets how much the customer paid
        /// </summary>
        public double Payment { get; private set; }

        /// <summary>
        /// Gets the total cost of the order
        /// </summary>
        public double TotalCost => order.Total;

        private double change;
        /// <summary>
        /// Gets how much change the customer receives
        /// </summary>
        public double Change
        {
            get
            {
               return Payment - TotalCost;
            }
            set
            {
                change = value;
            }
        }
 
        /// <summary>
        /// Breaks the change into the appropriate denominations
        /// </summary>
        public List<string> ChangeDenominations
        {
            get
            {
                double[] denominations = {100, 50, 20, 10, 5, 2, 1, 1, .50, .25, .10, .05, .01};
                int[] quantities = { Hundreds, Fifties, Twenties, Tens, Fives, Twos, Ones, Dollars, HalfDollars, Quarters, Dimes, Nickels, Pennies };
                List<string> answer = new List<string>();
                double count;
                double amount = Math.Round(Change, 2);
                for (int i = 0; i < denominations.Length; i++)
                {
                    count = amount / denominations[i];
                    int round = (int)count;
                    if (round != 0 && round <= quantities[i])
                    {
                        string number = $"Number of {denominations[i]}'s: {round}";
                        answer.Add(number);
                        amount -= (denominations[i] * round);
                        amount = Math.Round(amount, 2);    
                        
                        switch (i)
                        {
                            case 0:
                                drawer.RemoveBill(Bills.Hundred, round);
                                break;
                            case 1:
                                drawer.RemoveBill(Bills.Fifty, round);
                                break;
                            case 2:
                                drawer.RemoveBill(Bills.Twenty, round);
                                break;
                            case 3:
                                drawer.RemoveBill(Bills.Ten, round);
                                break;
                            case 4:
                                drawer.RemoveBill(Bills.Five, round);
                                break;
                            case 5:
                                drawer.RemoveBill(Bills.Two, round);
                                break;
                            case 6:
                                drawer.RemoveBill(Bills.One, round);
                                break;
                            case 7:
                                drawer.RemoveCoin(Coins.Dollar, round);
                                break;
                            case 8:
                                drawer.RemoveCoin(Coins.HalfDollar, round);
                                break;
                            case 9:
                                drawer.RemoveCoin(Coins.Quarter, round);
                                break;
                            case 10:
                                drawer.RemoveCoin(Coins.Dime, round);
                                break;
                            case 11:
                                drawer.RemoveCoin(Coins.Nickel, round);
                                break;
                            case 12:
                                drawer.RemoveCoin(Coins.Penny, round);
                                break;
                        }

                    }
                    
                }
                return answer;
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of pennies
        /// </summary>
        public int Pennies
        {
            get => drawer.Pennies;

            set
            {
                if (drawer.Pennies == value || value < 0) return;
                var quantity = value - drawer.Pennies;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Penny, quantity);
                    Payment += quantity * .01;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Penny, -quantity);
                    Payment += quantity * .01;
                }
                InvokePropertyChanged("Pennies");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of nickels
        /// </summary>
        public int Nickels
        {
            get => drawer.Nickels;

            set
            {
                if (drawer.Nickels == value || value < 0) return;
                var quantity = value - drawer.Nickels;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Nickel, quantity);
                    Payment += quantity * .05;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Nickel, -quantity);
                    Payment += quantity * .05;
                }
                InvokePropertyChanged("Nickels");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of dimes
        /// </summary>
        public int Dimes
        {
            get => drawer.Dimes;

            set
            {
                if (drawer.Dimes == value || value < 0) return;
                var quantity = value - drawer.Dimes;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dime, quantity);
                    Payment += quantity * .10;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dime, -quantity);
                    Payment += quantity * .10;
                }
                InvokePropertyChanged("Dimes");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of quarters
        /// </summary>
        public int Quarters
        {
            get => drawer.Quarters;

            set
            {
                if (drawer.Quarters == value || value < 0) return;
                var quantity = value - drawer.Quarters;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Quarter, quantity);
                    Payment += quantity * .25;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Quarter, -quantity);
                    Payment += quantity * .25;
                }
                InvokePropertyChanged("Quarters");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of half dollars
        /// </summary>
        public int HalfDollars
        {
            get => drawer.HalfDollars;

            set
            {
                if (drawer.HalfDollars == value || value < 0) return;
                var quantity = value - drawer.HalfDollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.HalfDollar, quantity);
                    Payment += quantity * .50;
                }

                else
                {
                    drawer.RemoveCoin(Coins.HalfDollar, -quantity);
                    Payment += quantity * .50;
                }
                InvokePropertyChanged("HalfDollars");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of dollars
        /// </summary>
        public int Dollars
        {
            get => drawer.Dollars;

            set
            {
                if (drawer.Dollars == value || value < 0) return;
                var quantity = value - drawer.Dollars;
                if (quantity > 0)
                {
                    drawer.AddCoin(Coins.Dollar, quantity);
                    Payment += quantity;
                }
                else
                {
                    drawer.RemoveCoin(Coins.Dollar, -quantity);
                    Payment += quantity;
                }
                InvokePropertyChanged("Dollars");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of ones
        /// </summary>
        public int Ones
        {
            get => drawer.Ones;

            set
            {
                if (drawer.Ones == value || value < 0) return;
                var quantity = value - drawer.Ones;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.One, quantity);
                    Payment += quantity;
                }
                else
                {
                    drawer.RemoveBill(Bills.One, -quantity);
                    Payment += quantity;
                }
                InvokePropertyChanged("Ones");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of twos
        /// </summary>
        public int Twos
        {
            get => drawer.Twos;

            set
            {
                if (drawer.Twos == value || value < 0) return;
                var quantity = value - drawer.Twos;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Two, quantity);
                    Payment += quantity * 2.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Two, -quantity);
                    Payment += quantity * 2.00;
                }
                InvokePropertyChanged("Twos");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of fives
        /// </summary>
        public int Fives
        {
            get => drawer.Fives;

            set
            {
                if (drawer.Fives == value || value < 0) return;
                var quantity = value - drawer.Fives;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Five, quantity);
                    Payment += quantity * 5.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Five, -quantity);
                    Payment += quantity * 5.00;
                }
                InvokePropertyChanged("Fives");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of tens
        /// </summary>
        public int Tens
        {
            get => drawer.Tens;

            set
            {
                if (drawer.Tens == value || value < 0) return;
                var quantity = value - drawer.Tens;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Ten, quantity);
                    Payment += quantity * 10.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Ten, -quantity);
                    Payment += quantity * 10.00;
                }
                InvokePropertyChanged("Tens");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of twenties
        /// </summary>
        public int Twenties
        {
            get => drawer.Twenties;

            set
            {
                if (drawer.Twenties == value || value < 0) return;
                var quantity = value - drawer.Twenties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Twenty, quantity);
                    Payment += quantity * 20.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Twenty, -quantity);
                    Payment += quantity * 20.00;
                }
                InvokePropertyChanged("Twenties");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of fifties
        /// </summary>
        public int Fifties
        {
            get => drawer.Fifties;

            set
            {
                if (drawer.Fifties == value || value < 0) return;
                var quantity = value - drawer.Fifties;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Fifty, quantity);
                    Payment += quantity * 50.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Fifty, -quantity);
                    Payment += quantity * 50.00;
                }
                InvokePropertyChanged("Fifties");
            }
        }

        /// <summary>
        /// Property that keeps track of the quantity of hundreds
        /// </summary>
        public int Hundreds
        {
            get => drawer.Hundreds;

            set
            {
                if (drawer.Hundreds == value || value < 0) return;
                var quantity = value - drawer.Hundreds;
                if (quantity > 0)
                {
                    drawer.AddBill(Bills.Hundred, quantity);
                    Payment += quantity * 100.00;
                }
                else
                {
                    drawer.RemoveBill(Bills.Hundred, -quantity);
                    Payment += quantity * 100.00;
                }
                InvokePropertyChanged("Hundreds");
            }
        }

        /// <summary>
        /// CashRegisterModelView constructor 
        /// </summary>
        /// <param name="cd">The cash drawer</param>
        /// <param name="ord">The current order</param>
        public CashRegisterModelView(CashDrawer cd, Order ord)
        {
            drawer = cd;
            order = ord;
        }

        /// <summary>
        /// Helper method for triggering PropertyChanged events
        /// </summary>
        /// <param name="denomination">The denomination property that is changing</param>
        void InvokePropertyChanged(string denomination)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(denomination));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("TotalValue"));
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs("Payment"));            
        }
    }
}
