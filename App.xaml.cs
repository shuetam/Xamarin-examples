using System;

using Xamarin.Forms;
using App02.Views;

namespace App02
{
    public partial class App : Application
    {
        public static bool UseMockDataStore = true;
        public static string BackendUrl = "https://localhost:5000";

        public App()
        {
            InitializeComponent();

            if (UseMockDataStore)
                DependencyService.Register<MockDataStore>();
            else
                DependencyService.Register<CloudDataStore>();

            if (Device.RuntimePlatform == Device.iOS)
                MainPage = new PhotosPage();
            else
                MainPage = new NavigationPage(new MyPageCode());

		}
	}
}