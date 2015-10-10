using RestaurantManager.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using RestaurantManager.UniversalWindows;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=234238

namespace RestaurantManager.UniversalWindows.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class OrderPage : Page
    {
        public OrderPage()
        {
            this.InitializeComponent();
        }

        private void HomeButton_Click(object sender, RoutedEventArgs e)
        {
            Frame.Navigate(typeof(MainPage));
        }

        private void buttonAddToOrder_Click(object sender, RoutedEventArgs e)
        {
            ObservableCollection<string> newStrings = new ObservableCollection<string>();

            if(currentlySelectedMenuItems.Items.Count > 0)
            {
                foreach (string s in currentlySelectedMenuItems.Items)
                {
                    newStrings.Add(s);
                }
            }

            if (menuItemsListView.SelectedItems.Count > 0)
            {
                foreach(string s in menuItemsListView.SelectedItems)
                {
                    newStrings.Add(s);
      
               }
                
            }

            currentlySelectedMenuItems.ItemsSource = newStrings;
          

        }

        private void buttonSubmitOrder_Click(object sender, RoutedEventArgs e)
        {
            if (menuItemsListView.SelectedItems.Count > 0)
            {
                foreach (string s in menuItemsListView.SelectedItems)
                {
                    App.DataManagerContext.OrderItems.Add(s);

                }
                Frame.Navigate(typeof(ExpeditePage));
            }
        }
    }
}
