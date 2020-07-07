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
    public partial class SampleBindingList : ContentPage
    {
        public SampleBindingList()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>();
            lstItems.Add(new ListItem
            {
                Title = "Xamarin for Android",
                Description = "Xamarin with Traditional Android Native UI"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin for IOS",
                Description = "Xamarin with Traditional IOS Native UI"
            });
            lstItems.Add(new ListItem
            {
                Title = "Xamarin Forms",
                Description = "Xamarin with Single UI for all platforms"
            });
            lvData.ItemsSource = lstItems;
            lvData.SelectedItem = lstItems[1];
        }

        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (ListItem)e.Item;
            await DisplayAlert("Keterangan",
                $"Title: {data.Title}, Desc: {data.Description}", "OK");
        }
    }
}