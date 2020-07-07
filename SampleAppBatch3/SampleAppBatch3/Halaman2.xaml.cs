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
        public Halaman2(string username)
        {
            InitializeComponent();
            _username = username;

            lblUsername.Text = _username;
        }


    }
}