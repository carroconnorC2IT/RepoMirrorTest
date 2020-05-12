using TelerikControls.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TelerikControls.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MenuPage : ContentPage
    {
        MainPage RootPage { get => Application.Current.MainPage as MainPage; }
        List<HomeMenuItem> menuItems;
        public MenuPage()
        {
            InitializeComponent();

            menuItems = new List<HomeMenuItem>
            {
                new HomeMenuItem {Id = MenuItemType.Browse, Title="Browse" },
                new HomeMenuItem {Id = MenuItemType.About, Title="About" },
                new HomeMenuItem {Id = MenuItemType.ListViewTemplateCell, Title = "ListViewTemplateCell"},
                new HomeMenuItem {Id = MenuItemType.Accordion, Title = "Accordion"}, 
                new HomeMenuItem {Id = MenuItemType.Entry, Title = "Numeric Input and Checkbox"},
                new HomeMenuItem {Id = MenuItemType.SideDrawer, Title = "Side Drawer"},
                new HomeMenuItem {Id = MenuItemType.PopUp, Title = "Pop Up"},
                new HomeMenuItem {Id = MenuItemType.Button, Title = "Button"}
            };

            ListViewMenu.ItemsSource = menuItems;

            ListViewMenu.SelectedItem = menuItems[0];
            ListViewMenu.ItemSelected += async (sender, e) =>
            {
                if (e.SelectedItem == null)
                    return;

                var id = (int)((HomeMenuItem)e.SelectedItem).Id;
                await RootPage.NavigateFromMenu(id);
            };
        }
    }
}