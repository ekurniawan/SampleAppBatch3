using SampleAppBatch3.Services;
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
            lvEmployee.ItemsSource = await _empServices.GetAll();
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
    }
}