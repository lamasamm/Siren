using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;


namespace TestingDB
{
    // Learn more about making custom code visible in the Xamarin.Forms previewer
    // by visiting https://aka.ms/xamarinforms-previewer
    [DesignTimeVisible(false)]
    public partial class MainPage : ContentPage
    {


        FireBaseHelper firebaseHelper = new FireBaseHelper();
        public MainPage()
        {
            InitializeComponent();
            BloodType_Picker.Items.Add("A+");
            BloodType_Picker.Items.Add("A-");
            BloodType_Picker.Items.Add("AB+");
            BloodType_Picker.Items.Add("AB-");
            BloodType_Picker.Items.Add("B+");
            BloodType_Picker.Items.Add("B-");
            BloodType_Picker.Items.Add("O+");
            BloodType_Picker.Items.Add("O-");

            w_Picker.Items.Add("Normal");
            w_Picker.Items.Add("Obese");
            w_Picker.Items.Add("Athlete");



        }

        // DISPLAY EXISTED PERSON
        protected async override void OnAppearing()
        {

            base.OnAppearing();
            var allPersons = await firebaseHelper.GetAllPersons();
         //  lstPersons.ItemsSource = allPersons;
        }


        // ADD NEW PERSON HANDLER
        private async void add_butt(object sender, EventArgs e)
        {
            await firebaseHelper.AddPerson(txtId.Text, txtName.Text, age.Text, w_Picker.SelectedItem.ToString(), m.IsChecked ,
           f.IsChecked, BloodType_Picker.SelectedItem.ToString(), sick1.IsChecked , sick2.IsChecked, sick3.IsChecked, sick4.IsChecked, familirity.IsChecked);
           
            await DisplayAlert("Success", "The account created Successfully", "OK");
            await Navigation.PushAsync(new UserMap());
           
         
        }

        // RETRIVE PERSON BY ID HANDLER
        private async void BtnRetrive_Clicked(object sender, EventArgs e)
        {
            var person = await firebaseHelper.GetPerson(txtId.Text);
            if (person != null)
            {
                txtId.Text = person.Username;
                txtName.Text = person.Password;
             //   await DisplayAlert("Success", "Person Retrive Successfully", "OK");

            }
            else
            {
                await DisplayAlert("Success", "No Sign up first", "OK");
            }

        }

    








    }
}
