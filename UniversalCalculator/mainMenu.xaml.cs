﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class mainMenu : Page
	{
		public mainMenu()
		{
			this.InitializeComponent();
		}

		//private void Button_Click(object sender, RoutedEventArgs e)
		//{

		//}

		private void mathsCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(MainPage));
		}

		private void mortgageCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(mortgage));
		}

		private void currencyConverterButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(Currency_Calculator_Page));
		}
		private void shoppingCartButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(hwshoppingcart));
		}

		private void tripCalculatorButton_Click(object sender, RoutedEventArgs e)
		{
			TripCalculatorTextBlock.Text += "Trip Calculator C# Code will be developed later";
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(mainMenu));
		}

	}
}
