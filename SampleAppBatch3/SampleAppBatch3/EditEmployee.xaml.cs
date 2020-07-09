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
    public partial class EditEmployee : ContentPage
    {
        private DataAccess _dataAccess;
        public EditEmployee()
        {
            InitializeComponent();
            _dataAccess = new DataAccess();
        }

        private async void btnEdit_Clicked(object sender, EventArgs e)
        {
            var editData = new Employee
            {
                EmpId = Convert.ToInt32(txtEmpID.Text),
                EmpName = txtEmpName.Text,
                Designation = txtDesignation.Text,
                Department = txtDepartment.Text,
                Qualification = txtQualification.Text
            };
            try
            {
                var result = _dataAccess.EditEmployee(editData);
                if(result!=1)
                {
                    await DisplayAlert("Error", "Gagal Update Data", "OK");
                }
                else
                {
                    await DisplayAlert("Keterangan", $"Update Emp {editData.EmpName} berhasil", "OK");
                    await Navigation.PopAsync();
                }
            }
            catch (Exception ex)
            {
                await DisplayAlert("Error", ex.Message, "OK");
            }
        }
    }
}