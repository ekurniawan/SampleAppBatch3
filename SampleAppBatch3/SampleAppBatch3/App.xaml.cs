using System;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleAppBatch3
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
            //MainPage = new MyMasterPage();
            MainPage = new NavigationPage(new ShowEmployeePage());
            Application.Current.Properties["username"] = string.Empty;
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
