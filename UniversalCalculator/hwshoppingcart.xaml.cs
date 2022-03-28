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
using Windows.UI.Popups;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace Calculator
{
	/// <summary>
	/// An empty page that can be used on its own or navigated to within a Frame.
	/// </summary>
	public sealed partial class hwshoppingcart : Page
	{
		public hwshoppingcart()
		{
			this.InitializeComponent();
		

		}
		const double DESKTOP_PRICE = 1000;
		const double KEYBOARD_PRICE = 100;
		const double MOUSE_PRICE = 80;

		private async void  calculateButton_Click(object sender, RoutedEventArgs e)
		{
			int desktopQuantity;
			int keyboarQuantity;
			int mouseQuantity;


			try
			{
				desktopQuantity = int.Parse(desktopQuantityTextBox.Text);
			}
			catch (Exception ex) // 
			{
				var dialogMessage = new MessageDialog("Error! Please enter a number " + ex.Message);
				await dialogMessage.ShowAsync();
				desktopQuantityTextBox.Focus(FocusState.Programmatic);
				desktopQuantityTextBox.SelectAll();
				return;
			}
			if (desktopQuantity < 0)
			{

				var dialog = new MessageDialog("Error, please,the enter a number bigger than 0");
				await dialog.ShowAsync();
				desktopQuantityTextBox.Focus(FocusState.Programmatic);
				desktopQuantityTextBox.SelectAll();
				return;
			}
			try
			{
				keyboarQuantity = int.Parse(keyboardQuantityTextBox.Text);
			}
			catch (Exception ex) // 
			{
				var dialogMessage = new MessageDialog("Error! Please enter a number " + ex.Message);
				await dialogMessage.ShowAsync();
				keyboardQuantityTextBox.Focus(FocusState.Programmatic);
				keyboardQuantityTextBox.SelectAll();
				return;
			}
			if (keyboarQuantity < 0)
			{

				var dialog = new MessageDialog("Error, please,the enter a number bigger than 0");
				await dialog.ShowAsync();
				keyboardQuantityTextBox.Focus(FocusState.Programmatic);
				keyboardQuantityTextBox.SelectAll();
				return;
			}

			try
			{
				mouseQuantity = int.Parse(mouseQuantityTextBox.Text);
			}
			catch (Exception ex) // 
			{
				var dialogMessage = new MessageDialog("Error! Please enter a number " + ex.Message);
				await dialogMessage.ShowAsync();
				mouseQuantityTextBox.Focus(FocusState.Programmatic);
				mouseQuantityTextBox.SelectAll();
				return;
			}
			if (mouseQuantity < 0)
			{

				var dialog = new MessageDialog("Error, please,the enter a number bigger than 0");
				await dialog.ShowAsync();
				mouseQuantityTextBox.Focus(FocusState.Programmatic);
				desktopQuantityTextBox.SelectAll();
				return;
			}


			double sum = 0;


			sum = desktopQuantity * DESKTOP_PRICE + keyboarQuantity * KEYBOARD_PRICE + mouseQuantity * MOUSE_PRICE;
			totalCostTextBlock.Text = sum.ToString("C");
		}

		private void exitButton_Click(object sender, RoutedEventArgs e)
		{
			this.Frame.Navigate(typeof(mainMenu));
		}
	}
}
