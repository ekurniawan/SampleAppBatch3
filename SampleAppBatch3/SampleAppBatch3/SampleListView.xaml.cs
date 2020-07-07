﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace SampleAppBatch3
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class SampleListView : ContentPage
    {
        public SampleListView()
        {
            InitializeComponent();
            List<string> lstNama = new List<string>();
            lstNama.Add("Erick");
            lstNama.Add("Budi");
            lstNama.Add("Bambang");
            lstNama.Add("Joni");

            lvData.ItemsSource = lstNama;
        }
    }
}