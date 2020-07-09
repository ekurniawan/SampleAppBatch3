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

        private async void MenuItem_Clicked(object sender, EventArgs e)
        {
            var myMenu = (MenuItem)sender;
            var empId = Convert.ToInt32(myMenu.CommandParameter);
            try
            {
                var konfirmasi = await DisplayAlert("Konfirmasi", "Yakin delete data?", "Yes", "No");
                if (konfirmasi)
                {
                    var delEmp = new Employee
                    {
                        EmpId = empId
                    };
                    var result = _dataAccess.DeleteEmployee(delEmp);
                    await DisplayAlert("Keterangan", "Data berhasil di delete", "OK");
                    OnAppearing();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}