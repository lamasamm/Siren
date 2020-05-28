using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Essentials;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace TestingDB
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class LogIn : ContentPage
    {
        FireBaseHelper firebaseHelper = new FireBaseHelper();
        public LogIn()
        {
            InitializeComponent();
        }




        private async void SignInButt_Clicked(object sender, EventArgs e)
        {
            var person = await firebaseHelper.GetPerson(Username_Entry.Text);
            if (person != null)
            {
                Username_Entry.Text = person.Username;
                Password_Entry.Text = person.Password;

                await Navigation.PushAsync(new UserMap());

            }
            if (Username_Entry.Text == "1" && Password_Entry.Text == "1")
            {
                await Navigation.PushAsync(new BuildingListView());

            }
           else if ((person == null) && (Username_Entry.Text != "1" && Password_Entry.Text != "1"))
            {

                await DisplayAlert("", "Sign up first", "OK");

            }
        }

        private void SignUpButt_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new MainPage());

        }


        




    }


    




    }







