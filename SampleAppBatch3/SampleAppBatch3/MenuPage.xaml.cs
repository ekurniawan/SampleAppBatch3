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

        private async void btnAlert_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayAlert("Konfirmasi", "Mau delete?", "Yes", "No");
            if (result)
            {
                await DisplayAlert("Keterangan", "Anda menjawab Yes","OK");
            }
            else
            {
                await DisplayAlert("Keterangan", "Anda menjawab No", "OK");
            }
        }

        private async void btnActionSheet_Clicked(object sender, EventArgs e)
        {
            var result = await DisplayActionSheet("Kirim via?", "Cancel", "Send",
                "Google Mail", "MS Mail", "Yahoo Mail");
            await DisplayAlert("Keterangan", $"Anda memilih: {result}", "OK");
        }

        private async void btnHal1_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new Halaman1());
        }
    }
}