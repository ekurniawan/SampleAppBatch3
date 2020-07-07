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
    public partial class Halaman2 : ContentPage
    {
        public Halaman2()
        {
            InitializeComponent();
        }

        private string _username;
        public Halaman2(string username,string password="")
        {
            InitializeComponent();
            _username = username;

            if (password != "")
                lblUsername.Text = $"Username: {_username} & Pass:{password}";
            else
                lblUsername.Text = _username;
        }

        private async void btnCekAppCurrent_Clicked(object sender, EventArgs e)
        {
            var data = Application.Current.Properties["username"].ToString();
            await DisplayAlert("Keterangan", $"Data: {data}", "OK");
        }
    }
}