﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingDB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BuildingListView : ContentPage
    {
        BuildingVM BVM;

        public BuildingListView()
        {
            InitializeComponent();

            BVM = new BuildingVM();
            this.BindingContext = BVM;
        }




        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // get selected item
            // var selectedItem = e.SelectedItem as FloorModel;
            //Navigate to details page with selected item info 
            await Navigation.PushAsync(new AdminPage());
        }
    }
}