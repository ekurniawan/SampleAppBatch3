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
            MainPage = new SampleCustomListview();
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
