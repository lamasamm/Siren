using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingDB
{
    public partial class AdminPage : ContentPage
    {
        FloorVM FVM;
        public AdminPage()
        {
            InitializeComponent();

            FVM = new FloorVM();
            this.BindingContext = FVM;

        }


        public async void OnItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            // get selected item
            var selectedItem = e.SelectedItem as FloorModel;
            //Navigate to details page with selected item info 
            await Navigation.PushAsync(new FloorDetails(selectedItem));
        }





    }
}