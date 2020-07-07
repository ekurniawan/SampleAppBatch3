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
    public partial class SampleCustomListview : ContentPage
    {
        public SampleCustomListview()
        {
            InitializeComponent();
            List<ListItem> lstItems = new List<ListItem>
            {
                new ListItem {Title="Monkey 1",Description="Monkey Xamarin 1",ImageSource="monkey.png",Price=10000},
                new ListItem {Title="Monkey 2",Description="Monkey Xamarin 2",ImageSource="monkey2.png",Price=20000},
                new ListItem {Title="Monkey 3",Description="Monkey Xamarin 3",ImageSource="monkey3.png",Price=50000},
                new ListItem {Title="Monkey 4",Description="Monkey Xamarin 4",ImageSource="monkey3.png",Price=50000},
                new ListItem {Title="Monkey 5",Description="Monkey Xamarin 5",ImageSource="monkey3.png",Price=50000}
            };
            lvData.ItemsSource = lstItems;
        }

        private async void lvData_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var data = (ListItem)e.Item;
            await DisplayAlert("Keterangan", $"Data: {data.Title}", "OK");
        }

        private async void ButtonEdit_Clicked(object sender, EventArgs e)
        {
            var btnEdit = (Button)sender;
            await DisplayAlert("Keterangan", 
                $"Title yg diedit :{btnEdit.CommandParameter}", "OK");
        }

        private async void ButtonDelete_Clicked(object sender, EventArgs e)
        {
            var btnDelete = (Button)sender;
            await DisplayAlert("Keterangan",
                $"Title yg didelete: {btnDelete.CommandParameter}", "OK");
        }
    }
}