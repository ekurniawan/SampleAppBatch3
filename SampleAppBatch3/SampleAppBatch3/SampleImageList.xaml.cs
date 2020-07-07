using SampleAppBatch3.Models;
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
    public partial class SampleImageList : ContentPage
    {
        public SampleImageList()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>
            {
                new ListItem {Title="Monkey 1",Description="Monkey Xamarin 1",ImageSource="monkey.png"},
                new ListItem {Title="Monkey 2",Description="Monkey Xamarin 2",ImageSource="monkey2.png"},
                new ListItem {Title="Monkey 3",Description="Monkey Xamarin 3",ImageSource="monkey3.png"}
            };
            lvData.ItemsSource = lstItems;
        }

        private async void btnBinding_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new SampleBindingList());
        }

        private async void btnBack_Clicked(object sender, EventArgs e)
        {
            await Navigation.PopAsync();
        }
    }
}