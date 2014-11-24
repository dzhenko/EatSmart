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
using Parse;
using EatSmart.Pages;
using EatSmart.Services;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace EatSmart.Views
{
    public sealed partial class AppBarNavigationView : UserControl
    {
        public AppBarNavigationView()
        {
            this.InitializeComponent();
        }
        
        private void OnNavigationAllButtonClicked(object sender, RoutedEventArgs e)
        {
            this.InnerNavigateToPage(sender, typeof(AllFoodCategoriesPage));
        }

        private void OnNavigationRichButtonClicked(object sender, RoutedEventArgs e)
        {
            this.InnerNavigateToPage(sender, typeof(RichInContentFoodsPage));
        }

        private void OnNavigationHomeButtonClicked(object sender, RoutedEventArgs e)
        {
            this.InnerNavigateToPage(sender, typeof(MainPage));
        }

        private void OnNavigationProfileButtonClicked(object sender, RoutedEventArgs e)
        {
            if (new UserSessionPersister().IsUserLoggedIn().Result)
            {
                this.InnerNavigateToPage(sender, typeof(ProfilePage));
            }
            else
            {
                this.InnerNavigateToPage(sender, typeof(LoginPage));
            }
        }

        private void OnNavigationBestFoodsButtonClicked(object sender, RoutedEventArgs e)
        {
            this.InnerNavigateToPage(sender, typeof(BestFoodsPage));
        }

        private void InnerNavigateToPage(object src, Type page)
        {
            // dirty dirty hack ... but fast :)
            ((((((src as AppBarButton).Parent as StackPanel).Parent as AppBarNavigationView)
                .Parent as Grid).Parent as Grid).Parent as Page).Frame.Navigate(page);
        }
    }
}
