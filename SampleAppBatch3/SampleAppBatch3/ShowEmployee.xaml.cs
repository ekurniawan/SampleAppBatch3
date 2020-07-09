using SampleAppBatch3.DAL;
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
    public partial class ShowEmployee : ContentPage
    {
        private DataAccess _dataAccess;
        public ShowEmployee()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        protected override void OnAppearing()
        {
            base.OnAppearing();
            lvEmployee.ItemsSource = _dataAccess.GetAllEmployee();
        }

        private async void btnAdd_Clicked(object sender, EventArgs e)
        {
            await Navigation.PushAsync(new AddEmployee());
        }

        private async void lvEmployee_ItemTapped(object sender, ItemTappedEventArgs e)
        {
            var selectedItem = (Employee)e.Item;
            EditEmployee frmEditEmployee = new EditEmployee();
            frmEditEmployee.BindingContext = selectedItem;
            await Navigation.PushAsync(frmEditEmployee);
        }
    }
}