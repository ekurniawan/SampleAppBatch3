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
    public partial class Halaman1 : ContentPage
    {
        public Halaman1()
        {
            InitializeComponent();
        }

        private async void btnKirim_Clicked(object sender, EventArgs e)
        {
            var username = txtUsername.Text;
            await Navigation.PushAsync(new Halaman2(username,"rahasia"));
        }

        private async void btnSetAppCurrent_Clicked(object sender, EventArgs e)
        {
            Application.Current.Properties["username"] = txtUsername.Text;
            await DisplayAlert("Keterangan", "Applciation Current berhasil diisi", "OK");
        }
    }
}