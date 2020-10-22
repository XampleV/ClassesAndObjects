using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
 

        class Profile
        {
            private string name;
            private int age;
            private string city;
            private string country;
            private string pronouns;
            private string[] hobbies;

            public Profile(string name, int age, string city, string country, string pronouns = "they/them")
            {

                this.name = name;
                this.age = age;
                this.city = city;
                this.country = country;
                this.pronouns = pronouns;

            }
            public string ViewProfile()
            {

                string hobbiesString = "";
                foreach (string i in this.hobbies)
                {
                    hobbiesString += $"{i}\n";

                }
                return $"Name: {this.name}, age: {this.age}, city: {this.city}, country: {this.country}, pronouns: {this.pronouns}\nHobbies:\n{hobbiesString}";
            }
            public void SetHobbies(string[] hobbies)
            {
                this.hobbies = hobbies;
            }
        }
    
}
