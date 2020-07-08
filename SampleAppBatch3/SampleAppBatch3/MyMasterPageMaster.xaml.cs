using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleAppBatch3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class MyMasterPageMaster : ContentPage
    {
        public ListView ListView;

        public MyMasterPageMaster()
        {
            InitializeComponent();

            BindingContext = new MyMasterPageMasterViewModel();
            ListView = MenuItemsListView;
        }

        class MyMasterPageMasterViewModel : INotifyPropertyChanged
        {
            public ObservableCollection<MyMasterPageMasterMenuItem> MenuItems { get; set; }

            public MyMasterPageMasterViewModel()
            {
                MenuItems = new ObservableCollection<MyMasterPageMasterMenuItem>(new[]
                {
                    new MyMasterPageMasterMenuItem { Id = 0, Title = "Page 1" },
                    new MyMasterPageMasterMenuItem { Id = 1, Title = "Page 2" },
                    new MyMasterPageMasterMenuItem { Id = 2, Title = "Page 3" },
                    new MyMasterPageMasterMenuItem { Id = 3, Title = "Page 4" },
                    new MyMasterPageMasterMenuItem { Id = 4, Title = "Page 5" },
                });
            }

            #region INotifyPropertyChanged Implementation
            public event PropertyChangedEventHandler PropertyChanged;
            void OnPropertyChanged([CallerMemberName] string propertyName = "")
            {
                if (PropertyChanged == null)
                    return;

                PropertyChanged.Invoke(this, new PropertyChangedEventArgs(propertyName));
            }
            #endregion
        }
    }
}