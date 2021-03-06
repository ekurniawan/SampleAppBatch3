﻿using System;
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
                    new MyMasterPageMasterMenuItem { Id = 0, Title = "Main Menu",
                        TargetType=typeof(MenuPage),ImageSource="telpon.png" },
                    new MyMasterPageMasterMenuItem { Id = 1, Title = "Data Employee",
                        TargetType=typeof(ShowEmployeePage),ImageSource="jam.png"},
                    new MyMasterPageMasterMenuItem { Id = 2, Title = "Sample Tabbed Page",
                        TargetType=typeof(MyTabbedPage),ImageSource="telpon.png"},
                    new MyMasterPageMasterMenuItem { Id = 3, Title = "Sample Custom List",
                        TargetType=typeof(SampleCustomListview),ImageSource="jam.png"},
                    new MyMasterPageMasterMenuItem { Id = 4, Title = "Sample Grid Layout",
                        TargetType=typeof(SampleGridLayout),ImageSource="telpon.png"},
                    new MyMasterPageMasterMenuItem { Id = 5, Title = "Sample List View",
                        TargetType=typeof(SampleListView),ImageSource="jam.png"},
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