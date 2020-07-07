using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleAppBatch3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MenuPage : ContentPage
    {
        public MenuPage()
        {
            InitializeComponent();
        }

        private async void btnListImage_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleImageList());
        }

        private async void menuSampleList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleListView());
        }

        private async void menuCustomList_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleCustomListview());
        }
    }
}