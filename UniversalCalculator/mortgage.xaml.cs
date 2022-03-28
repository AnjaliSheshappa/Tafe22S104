using System;
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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class mortgage : Page
	{
		public mortgage()
		{
			this.InitializeComponent();
		}

		private void calculateButton_Click(object sender, RoutedEventArgs e)
		{
			double borrowPrincipal;
			double years;
			double months;
			double yearlyInterstRate;
			double monthlyInterstRate;
			double MonthlyRepayment;
			double noOfMonths;

			borrowPrincipal = double.Parse(borrowTextBox.Text);
			years = double.Parse(yearsTextBox.Text);
			months = double.Parse(monthsTextBox.Text);
			yearlyInterstRate = double.Parse(interstTextBox.Text) / 100.0;
			//monthlyInterstRate = double.Parse(montlyInterstTextBox.Text)/100;
			//MonthlyRepayment= double.Parse(repaymentTextBox.Text);
			monthlyInterstRate = yearlyInterstRate / 12.0;
			noOfMonths = years * 12 + months;



			MonthlyRepayment = borrowPrincipal * monthlyInterstRate * (Math.Pow((1.0 + monthlyInterstRate), noOfMonths)) /
				((Math.Pow((1.0 + monthlyInterstRate), noOfMonths)) - 1);


			montlyInterstTextBox.Text = (yearlyInterstRate / 12.0).ToString("N4") + "%";

			repaymentTextBox.Text = MonthlyRepayment.ToString("N");
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(mainMenu));
		}
	}
}
