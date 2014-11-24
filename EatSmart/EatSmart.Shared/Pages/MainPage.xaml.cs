using EatSmart.Common;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.Graphics.Display;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Parse;
using Windows.UI.Popups;
using Windows.Networking.Connectivity;
using EatSmart.Services;
using Windows.Devices.Sensors;
using Windows.Devices.Geolocation;
using System.Threading.Tasks;

// The Basic Page item template is documented at http://go.microsoft.com/fwlink/?LinkID=390556

namespace EatSmart.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private NavigationHelper navigationHelper;
        private ObservableDictionary defaultViewModel = new ObservableDictionary();

        private Accelerometer acc;

        public MainPage()
        {
            this.InitializeComponent();

            this.navigationHelper = new NavigationHelper(this);
            this.navigationHelper.LoadState += this.NavigationHelper_LoadState;
            this.navigationHelper.SaveState += this.NavigationHelper_SaveState;

            try
            {
                var InternetConnectionProfile = NetworkInformation.GetInternetConnectionProfile();

                if (InternetConnectionProfile == null)
                {
                    new MessageDialog("You dont have any internet connection").ShowAsync();
                }
            }
            catch (Exception ex)
            {
            }

            if (App.DbNeedsInitializing)
            {
                new MessageDialog("Data is currently being populated .. please be patient").ShowAsync();
            }
            
            acc = Accelerometer.GetDefault();
            acc.Shaken += Shaken;
            acc.ReportInterval = 1;
        }

        async private void Shaken(object sender, AccelerometerShakenEventArgs args)
        {
            var res = await this.GetLocation();
            await new MessageDialog(res).ShowAsync();
        }

        private async Task<string> GetLocation()
        {
            string text = string.Empty;

            //var geo = new Geolocator();
            //Geoposition pos = await geo.GetGeopositionAsync();
            //text += "Latitude: " + pos.Coordinate.Point.Position.Latitude.ToString() + "; ";
            //text += "Longitude: " + pos.Coordinate.Point.Position.Longitude.ToString();
            //text += " (Accuracy: " + pos.Coordinate.Accuracy.ToString()+")  ";

            text += "Latitude: 32.42; ";
            text += "Longitude: 31.33";
            text += " (Accuracy: 15m)  "; 

            var compas = Compass.GetDefault();
            var read = compas.GetCurrentReading();
            text += string.Format("{0,5:0.00}", read.HeadingMagneticNorth);
            return text;
        }

        /// <summary>
        /// Gets the <see cref="NavigationHelper"/> associated with this <see cref="Page"/>.
        /// </summary>
        public NavigationHelper NavigationHelper
        {
            get { return this.navigationHelper; }
        }

        /// <summary>
        /// Gets the view model for this <see cref="Page"/>.
        /// This can be changed to a strongly typed view model.
        /// </summary>
        public ObservableDictionary DefaultViewModel
        {
            get { return this.defaultViewModel; }
        }

        /// <summary>
        /// Populates the page with content passed during navigation.  Any saved state is also
        /// provided when recreating a page from a prior session.
        /// </summary>
        /// <param name="sender">
        /// The source of the event; typically <see cref="NavigationHelper"/>
        /// </param>
        /// <param name="e">Event data that provides both the navigation parameter passed to
        /// <see cref="Frame.Navigate(Type, Object)"/> when this page was initially requested and
        /// a dictionary of state preserved by this page during an earlier
        /// session.  The state will be null the first time a page is visited.</param>
        private void NavigationHelper_LoadState(object sender, LoadStateEventArgs e)
        {
        }

        /// <summary>
        /// Preserves state associated with this page in case the application is suspended or the
        /// page is discarded from the navigation cache.  Values must conform to the serialization
        /// requirements of <see cref="SuspensionManager.SessionState"/>.
        /// </summary>
        /// <param name="sender">The source of the event; typically <see cref="NavigationHelper"/></param>
        /// <param name="e">Event data that provides an empty dictionary to be populated with
        /// serializable state.</param>
        private void NavigationHelper_SaveState(object sender, SaveStateEventArgs e)
        {
        }

        #region NavigationHelper registration

        /// <summary>
        /// The methods provided in this section are simply used to allow
        /// NavigationHelper to respond to the page's navigation methods.
        /// <para>
        /// Page specific logic should be placed in event handlers for the  
        /// <see cref="NavigationHelper.LoadState"/>
        /// and <see cref="NavigationHelper.SaveState"/>.
        /// The navigation parameter is available in the LoadState method 
        /// in addition to page state preserved during an earlier session.
        /// </para>
        /// </summary>
        /// <param name="e">Provides data for navigation methods and event
        /// handlers that cannot cancel the navigation request.</param>
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedTo(e);
        }

        protected override void OnNavigatedFrom(NavigationEventArgs e)
        {
            this.navigationHelper.OnNavigatedFrom(e);
        }

        #endregion



        private void OnAllButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(AllFoodCategoriesPage));
        }

        private void OnRichButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(RichInContentFoodsPage));
        }

        private void OnHomeButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(MainPage));
        }

        private void OnProfileButtonClicked(object sender, RoutedEventArgs e)
        {
            if (new UserSessionPersister().IsUserLoggedIn().Result)
            {
                this.Frame.Navigate(typeof(ProfilePage));
            }
            else
            {
                this.Frame.Navigate(typeof(LoginPage));
            }
        }

        private void OnBestFoodsButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Frame.Navigate(typeof(BestFoodsPage));
        }

        private void OnInfoButtonClicked(object sender, RoutedEventArgs e)
        {
            this.Shaken(null, null);
        }
    }
}
