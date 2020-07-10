using SampleAppBatch3.Models;
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
    public partial class AddEmployeePage : ContentPage
    {
        private EmployeeServices _empService;
        public AddEmployeePage()
        {
            InitializeComponent();
            _empService = new EmployeeServices();
        }

        private async void btnSave_Clicked(object sender, EventArgs e)
        {
            var insertEmp = new Employee
            {
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                await _empService.Insert(insertEmp);
                await DisplayAlert("Keterangan", $"Data Employee {insertEmp.EmpName} berhasil ditambahkan",
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