using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.ApplicationModel;
using Windows.ApplicationModel.Activation;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Media.Animation;
using Windows.UI.Xaml.Navigation;
using Parse;
using EatSmart.Pages;
using EatSmart.ViewModels;
using EatSmart.ViewModels.Basic;
using SQLite;
using System.Threading.Tasks;
using Windows.UI.Popups;
using Windows.Networking.Connectivity;
using EatSmart.Models;
using Windows.Storage;

// The Blank Application template is documented at http://go.microsoft.com/fwlink/?LinkId=234227

namespace EatSmart
{
    /// <summary>
    /// Provides application-specific behavior to supplement the default Application class.
    /// </summary>
    public sealed partial class App : Application
    {
#if WINDOWS_PHONE_APP
        private TransitionCollection transitions;
#endif

        /// <summary>
        /// Initializes the singleton application object.  This is the first line of authored code
        /// executed, and as such is the logical equivalent of main() or WinMain().
        /// </summary>
        public App()
        {
            this.InitializeParse();
            var dbNeedsInitializing = this.PopulateBase().Result;
            this.InitializeComponent();
            this.Suspending += this.OnSuspending;

            //Get the Internet connection profile
            string connectionProfileInfo = string.Empty;
        }

        public static bool DbNeedsInitializing = false;

        public static Lazy<SQLiteAsyncConnection> Database
            = new Lazy<SQLiteAsyncConnection>(() => new SQLiteAsyncConnection("AppEatFreshDb"));

        private void InitializeParse()
        {
            ParseClient.Initialize("jEgHOJq0IJmT19ZvHzoscwIWx1whyu9l9PZLunrO", "F0czoYvEHzayV2MI0wkNTxirYsrOpgThLEccn98N");

            ParseObject.RegisterSubclass<FoodCategory>();
            ParseObject.RegisterSubclass<FoodCategoryItem>();
            ParseObject.RegisterSubclass<SuitableFoodCategory>();
            ParseObject.RegisterSubclass<SuitableFoodCategoryItem>();
        }

        private async Task<bool> PopulateBase()
        {
            var conn = Database.Value;

            await conn.CreateTablesAsync<FoodCategoryViewModel,
                                        FoodCategoryItemViewModel,
                                        SuitableFoodCategoryViewModel,
                                        SuitableFoodCategoryItemViewModel,
                                        UserViewModel>();

            await conn.CreateTableAsync<UserSessionHolderViewModel>();

            if (conn.Table<FoodCategoryItemViewModel>().CountAsync().Result > 0)
            {
                DbNeedsInitializing = false;
                return false;
            }

            DbNeedsInitializing = true;

            var foodCategories = new ParseQuery<FoodCategory>().Limit(1000)
                .FindAsync().Result.AsQueryable().Select(FoodCategoryViewModel.FromData).ToList();

            var foodCategoryItems1 = new ParseQuery<FoodCategoryItem>().Limit(500).Skip(0)
                .FindAsync().Result.AsQueryable().Select(FoodCategoryItemViewModel.FromData).ToList();

            var foodCategoryItems2 = new ParseQuery<FoodCategoryItem>().Limit(1000).Skip(500)
                .FindAsync().Result.AsQueryable().Select(FoodCategoryItemViewModel.FromData).ToList();

            var suitableFoodCategories = new ParseQuery<SuitableFoodCategory>().Limit(1000)
                .FindAsync().Result.AsQueryable().Select(SuitableFoodCategoryViewModel.FromData).ToList();

            var suitableFoodCategoryItems1 = new ParseQuery<SuitableFoodCategoryItem>().Limit(500).Skip(0)
                .FindAsync().Result.AsQueryable().Select(SuitableFoodCategoryItemViewModel.FromData).ToList();

            var suitableFoodCategoryItems2 = new ParseQuery<SuitableFoodCategoryItem>().Limit(1000).Skip(500)
                .FindAsync().Result.AsQueryable().Select(SuitableFoodCategoryItemViewModel.FromData).ToList();

            conn.InsertAllAsync(foodCategories);

            conn.InsertAllAsync(foodCategoryItems1);
            conn.InsertAllAsync(foodCategoryItems2);

            conn.InsertAllAsync(suitableFoodCategories);

            conn.InsertAllAsync(suitableFoodCategoryItems1);
            conn.InsertAllAsync(suitableFoodCategoryItems2).ContinueWith(x => DbNeedsInitializing = false);

            return true;
        }

        public static Lazy<StorageFile> CurrentLoggedUsername = new Lazy<StorageFile>(() => GetStorageFile().Result);
        private static async Task<StorageFile> GetStorageFile()
        {
            return await ApplicationData.Current.LocalFolder
                .CreateFileAsync("UserDetails", CreationCollisionOption.ReplaceExisting);
        }
        /// <summary>
        /// Invoked when the application is launched normally by the end user.  Other entry points
        /// will be used when the application is launched to open a specific file, to display
        /// search results, and so forth.
        /// </summary>
        /// <param name="e">Details about the launch request and process.</param>
        protected override void OnLaunched(LaunchActivatedEventArgs e)
        {
#if DEBUG
            if (System.Diagnostics.Debugger.IsAttached)
            {
                this.DebugSettings.EnableFrameRateCounter = true;
            }
#endif

            Frame rootFrame = Window.Current.Content as Frame;

            // Do not repeat app initialization when the Window already has content,
            // just ensure that the window is active
            if (rootFrame == null)
            {
                // Create a Frame to act as the navigation context and navigate to the first page
                rootFrame = new Frame();

                // TODO: change this value to a cache size that is appropriate for your application
                rootFrame.CacheSize = 1;

                if (e.PreviousExecutionState == ApplicationExecutionState.Terminated)
                {
                    // TODO: Load state from previously suspended application
                }

                // Place the frame in the current Window
                Window.Current.Content = rootFrame;
            }

            if (rootFrame.Content == null)
            {
#if WINDOWS_PHONE_APP
                // Removes the turnstile navigation for startup.
                if (rootFrame.ContentTransitions != null)
                {
                    this.transitions = new TransitionCollection();
                    foreach (var c in rootFrame.ContentTransitions)
                    {
                        this.transitions.Add(c);
                    }
                }

                rootFrame.ContentTransitions = null;
                rootFrame.Navigated += this.RootFrame_FirstNavigated;
#endif

                // When the navigation stack isn't restored navigate to the first page,
                // configuring the new page by passing required information as a navigation
                // parameter

                if (!rootFrame.Navigate(typeof(MainPage), e.Arguments))
                {
                    throw new Exception("Failed to create initial page");
                }
            }

            // Ensure the current window is active
            Window.Current.Activate();
        }

#if WINDOWS_PHONE_APP
        /// <summary>
        /// Restores the content transitions after the app has launched.
        /// </summary>
        /// <param name="sender">The object where the handler is attached.</param>
        /// <param name="e">Details about the navigation event.</param>
        private void RootFrame_FirstNavigated(object sender, NavigationEventArgs e)
        {
            var rootFrame = sender as Frame;
            rootFrame.ContentTransitions = this.transitions ?? new TransitionCollection() { new NavigationThemeTransition() };
            rootFrame.Navigated -= this.RootFrame_FirstNavigated;
        }
#endif

        /// <summary>
        /// Invoked when application execution is being suspended.  Application state is saved
        /// without knowing whether the application will be terminated or resumed with the contents
        /// of memory still intact.
        /// </summary>
        /// <param name="sender">The source of the suspend request.</param>
        /// <param name="e">Details about the suspend request.</param>
        private void OnSuspending(object sender, SuspendingEventArgs e)
        {
            var deferral = e.SuspendingOperation.GetDeferral();

            // TODO: Save application state and stop any background activity
            deferral.Complete();
        }
    }
}