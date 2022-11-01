using System.Linq;
using System.Collections.Generic;

//Create a list of video game names.
var gameName = new List<string> { "Fifa23", "Madden", "Red Dead Redemption", "Super Mario", "Tetris", "Overwatch", "Minecraft", "Fortnite", "League of Legends", "Grand Theft Auto V" };

//Order the list of games by length of the game name.
//Use the lambda expression in this exercise as well.
gameName.OrderBy(x => x.Length).ToList().ForEach(x => Console.WriteLine(x));
