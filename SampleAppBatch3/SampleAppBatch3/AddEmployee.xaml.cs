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
    public partial class AddEmployee : ContentPage
    {
        private DataAccess _dataAccess;
        public AddEmployee()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var newEmp = new Employee
            {
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                var result = _dataAccess.InsertEmployee(newEmp);
                await DisplayAlert("Keterangan", $"Data Emp {newEmp.EmpName} berhasil ditambah",
                    "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", ex.Message, "OK");
            }
        }
    }
}