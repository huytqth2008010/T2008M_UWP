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
using T2008M_UWP.GroupHomework.Models;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=234238

namespace T2008M_UWP.GroupHomework
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public static Frame _mainFrame;
        public MainPage()
        {
            this.InitializeComponent();
            _mainFrame = MainFrame;
            MainFrame.Navigate(typeof(GroupHomework.EatIn));
            
        }
        private void HomePage(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(GroupHomework.Home));
        }
        private void EatIn(object sender, RoutedEventArgs e)
        {
            MainFrame.Navigate(typeof(GroupHomework.EatIn));
        }

        private void FontIcon_Tapped(object sender, TappedRoutedEventArgs e)
        {
            SP.IsPaneOpen = !SP.IsPaneOpen;
        }

        private void Menu_Loaded(object sender, RoutedEventArgs e)
        {
            var item1 = new MenuItem() { Name = "Home", MenuPage = "home", Icon = "\uE80f" };
            var item2 = new MenuItem() { Name = "Eat-In", MenuPage = "eat", Icon = "\uEb68" };
            var item3 = new MenuItem() { Name = "Collection", MenuPage = "coll", Icon = "\uE71d" };
            var item4 = new MenuItem() { Name = "Delivery", MenuPage = "del", Icon = "\uEa5e" };
            var item5 = new MenuItem() { Name = "Take Away", MenuPage = "take", Icon = "\uE74c" };
            var item6 = new MenuItem() { Name = "Driver Payment", MenuPage = "pay", Icon = "\uE75b" };
            var item7 = new MenuItem() { Name = "Customers", MenuPage = "cus", Icon = "\uE748" };
            // Gia su co 1 danh sach category
            // new MenuItem() { Name = "Ten cua category", MenuPage = "category", Icon = "\uE946" };
            Menu.Items.Add(item1);
            Menu.Items.Add(item2);
            Menu.Items.Add(item3);
            Menu.Items.Add(item4);
            Menu.Items.Add(item5);
            Menu.Items.Add(item6);
            Menu.Items.Add(item7);
          
        }

        private void ListViewItem_Tapped(object sender, TappedRoutedEventArgs e)
        {
            MenuItem selectedItem = (MenuItem)Menu.SelectedItem;
            switch (selectedItem.MenuPage)
            {
                case "home": MainFrame.Navigate(typeof(GroupHomework.Home), selectedItem); break; // Page
                case "eat": MainFrame.Navigate(typeof(GroupHomework.EatIn)); break;
                case "coll": MainFrame.Navigate(typeof(GroupHomework.Collection)); break;
                case "del": MainFrame.Navigate(typeof(GroupHomework.Delivery)); break;
                case "take": MainFrame.Navigate(typeof(GroupHomework.TakeAway)); break;
                case "pay": MainFrame.Navigate(typeof(GroupHomework.DriverPayMent)); break;
                case "cus": MainFrame.Navigate(typeof(GroupHomework.Customers)); break;
                    //case "category": MainFrame.Navigate(typeof(Pages.Category),category); break;
            }
        }
       
    }
}
