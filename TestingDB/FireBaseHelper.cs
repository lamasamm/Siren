using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Firebase.Database;
using Firebase.Database.Query;
using TestingDB.Models;

namespace TestingDB
{
    class FireBaseHelper
    {

      
  
      FirebaseClient firebase = new FirebaseClient("https://coastal-arcana-274814.firebaseio.com/");
      private readonly object firebaseHelper;

         

        //TO GET ALL PERSON IN THE LIST VIEW
        public async Task <List<Person>> GetAllPersons()
        {

            return (await firebase.Child("Persons").OnceAsync<Person>()).Select(item => new Person
              {
               
                  Username = item.Object.Username,
                  Password = item.Object.Password
              }).ToList();
        }

        

        // ADDING IN THE DB
        public async Task AddPerson(String username, String password, String age ,String weight, Boolean male , Boolean female, String blood , Boolean physical_d , Boolean resp_d ,Boolean heart_d , Boolean muscle_d , Boolean knowTheBuilding)
        {

            await firebase
              .Child("Persons")
              .PostAsync(new Person() { Username= username, Password = password , Age= age , Weight= weight, Male =male, Female= female,Bloodtype=blood , Physical_d = physical_d, Resp_d= resp_d, Heart_d= heart_d , Muscle_d= muscle_d , KnowTheBuilding = knowTheBuilding });
        }




        //TO GET A PERSON BY ID
        public async Task<Person> GetPerson(String personId)
        {
            var allPersons = await GetAllPersons();
            await firebase
              .Child("Persons")
              .OnceAsync<Person>();
            return allPersons.Where(a => a.Username == personId).FirstOrDefault();
        }
















        //TO UPDATE PERSON INFO IN THE DB
        public async Task UpdatePerson(String personId, string name)
        {
            var toUpdatePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Username == personId).FirstOrDefault();

            await firebase
              .Child("Persons")
              .Child(toUpdatePerson.Key)
              .PutAsync(new Person() { Username= personId, Password = name });

        }

        // TO DELETE FROM THE DB USING ID
        public async Task DeletePerson(String personId)
        {
            var toDeletePerson = (await firebase
              .Child("Persons")
              .OnceAsync<Person>()).Where(a => a.Object.Username == personId).FirstOrDefault();
            await firebase.Child("Persons").Child(toDeletePerson.Key).DeleteAsync();

        }






    }
}
