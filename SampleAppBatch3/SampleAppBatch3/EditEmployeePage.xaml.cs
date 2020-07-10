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
    public partial class EditEmployeePage : ContentPage
    {
        private EmployeeServices _empService;
        public EditEmployeePage()
        {
            InitializeComponent();
            _empService = new EmployeeServices();
        }

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            var editEmp = new Employee
            {
                EmpId = Convert.ToInt32(txtEmpID.Text),
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                await _empService.Edit(editEmp);
                await DisplayAlert("Keterangan", "Edit Employee Berhasil", "OK");
                await Navigation.PopAsync();
            }
            catch (Exception ex)
            {
                await DisplayAlert("Kesalahan", ex.Message, "OK");
            }
        }
    }
}