using SampleAppBatch3.Models;
using SampleAppBatch3.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleAppBatch3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ShowEmployeePage : ContentPage
    {
        private EmployeeServices _empServices;
        public ShowEmployeePage()
        {
            InitializeComponent();
            _empServices = new EmployeeServices();
        }

        private async Task GetData()
        {
            var current = Connectivity.NetworkAccess;
            //var profiles = Connectivity.ConnectionProfiles;
            //if(profiles.Contains(ConnectionProfile.WiFi))
            if (current == NetworkAccess.Internet)
            {
                lvEmployee.ItemsSource = await _empServices.GetAll();
            }
            else
            {
                await DisplayAlert("Kesalahan", "Tidak ada koneksi internet", "OK");
            }
        }

        protected async override void OnAppearing()
        {
            base.OnAppearing();
            await GetData();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployeePage());
        }

        private async void lvEmployee_Refreshing(object sender, EventArgs e)
        {
            await GetData();
            lvEmployee.IsRefreshing = false;
        }

        private async void lvEmployee_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var editEmp = (Employee)e.Item;
            EditEmployeePage editEmpPage = new EditEmployeePage();
            editEmpPage.BindingContext = editEmp;
            await Navigation.PushAsync(editEmpPage);
        }
    }
}