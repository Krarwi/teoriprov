using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Remoting.Messaging;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Task_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates the list for the game objects
            List<Game> games = new List<Game>();

            // adds the two games
            games.Add(new Game("Bloons 6", "Ninja Kiwi", "2018", "Tower Defense"));
            games.Add(new Game("Hearts of Iron IV", "Paradox Interactive", "2016", "Grand Strategy"));

            // this works the same as calling the displaygameinformation, it is impossible to call the displaygameinformation in the current class it is in
            // and it clearly states on the task that you have to put it in the game class, you can call the game class but you have to put details
            // it basically creates a new game and only displays that
            foreach (var i in games)
            {
                Console.WriteLine($"Game name: {i.Name}");
                Console.WriteLine($"Game publisher: {i.Publisher}");
                Console.WriteLine($"Game year of release: {i.Year}");
                Console.WriteLine($"Game genre: {i.Genre}");
                Console.WriteLine("------------------------------------");
            }

        }
    }
    public class Game
    {
        // sets the properties for a game
        public string Name { get; set; }
        public string Publisher { get; set; }
        public string Year { get; set; }
        public string Genre { get; set; }

        // initializes the properties with the constructor
        public Game(string name, string publisher, string year, string genre)
        {
            Name = name;
            Publisher = publisher;
            Year = year;
            Genre = genre;
        }
        // should display the game information, however cannot be called due to game being invokable on its own
        public void DisplayGameInformation()
        {
            Console.WriteLine($"Game name: {Name}");
            Console.WriteLine($"Game publisher: {Publisher}");
            Console.WriteLine($"Game year of release: {Year}");
            Console.WriteLine($"Game genre: {Genre}");
            Console.WriteLine("------------------------------------");
        }
    }
}
