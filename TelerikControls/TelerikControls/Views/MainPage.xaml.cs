using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Threading.Tasks;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

using TelerikControls.Models;

namespace TelerikControls.Views
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : MasterDetailPage
    {
        Dictionary<int, NavigationPage> MenuPages = new Dictionary<int, NavigationPage>();
        public MainPage()
        {
            InitializeComponent();

            MasterBehavior = MasterBehavior.Popover;

            MenuPages.Add((int)MenuItemType.Browse, (NavigationPage)Detail);
        }

        public async Task NavigateFromMenu(int id)
        {
            if (!MenuPages.ContainsKey(id))
            {
                switch (id)
                {
                    case (int)MenuItemType.Browse:
                        MenuPages.Add(id, new NavigationPage(new ItemsPage()));
                        break;
                    case (int)MenuItemType.About:
                        MenuPages.Add(id, new NavigationPage(new AboutPage()));
                        break;
                    case (int)MenuItemType.ListViewTemplateCell:
                        MenuPages.Add(id, new NavigationPage(new ListViewTemplateCell()));
                        break;
                    case (int)MenuItemType.Accordion:
                        MenuPages.Add(id, new NavigationPage(new AccordionPage()));
                        break;
                    case (int)MenuItemType.Entry:
                        MenuPages.Add(id, new NavigationPage(new EntryPage()));
                        break;
                    case (int)MenuItemType.SideDrawer:
                        MenuPages.Add(id, new NavigationPage(new SideDrawer()));
                        break;
                    case (int)MenuItemType.PopUp:
                        MenuPages.Add(id, new NavigationPage(new PopupPage()));
                        break;
                    case (int)MenuItemType.Button:
                        MenuPages.Add(id, new NavigationPage(new ButtonPage()));
                        break;
                }
            }

            var newPage = MenuPages[id];

            if (newPage != null && Detail != newPage)
            {
                Detail = newPage;

                if (Device.RuntimePlatform == Device.Android)
                    await Task.Delay(100);

                IsPresented = false;
            }
        }
    }
}