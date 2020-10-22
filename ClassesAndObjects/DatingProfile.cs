using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesAndObjects
{
 

        class Profile
        {
            private string gamerUsername;
            private int steamGamesAmount;
            private string favGame;
            private string[] favGamesList;

            public Profile(string gamerUsername, int steamGamesAmount, string favGame)
            {

                this.gamerUsername = gamerUsername;
                this.steamGamesAmount = steamGamesAmount;
                this.favGame = favGame;
            }
            public string ViewProfile()
            {

                string hobbiesString = "";
                foreach (string i in this.favGamesList)
                {
                    hobbiesString += $"{i}\n";

                }
            return $"Username: {gamerUsername}\nAmount of games: {steamGamesAmount}\nFav game: {favGame}\nFav game list:\n{hobbiesString}";
            }
            public void SetHobbies(string[] hobbies)
            {
                this.favGamesList = hobbies;
            }
        }
    
}
