using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // creates the dictionary with the key as a string and the value as a string
            Dictionary<string, string> words = new Dictionary<string, string>();

            // exit integer (used for the exit option)
            int exit = 1;
            // while the exit integer is one all of this happens (repeating menu)
            while (exit == 1)
            {
                // prints the menu
                Console.WriteLine("1 - Add a word");
                Console.WriteLine("2 - Remove a word");
                Console.WriteLine("3 - Word list");
                Console.WriteLine("4 - Exit");

                // reads the input of the user
                string choice = Console.ReadLine();

                // uses the input of the sure to check what option they chose
                switch (choice)
                {
                    // if they chose option one (adding a word)
                    case "1":
                        Console.WriteLine("Insert word:");
                        string word = Console.ReadLine();
                        // if the word is in the dictionary already
                        if (words.ContainsKey(word))
                        {
                            Console.WriteLine($"This word already exists, do you want to overwrite it? Y/N");
                            string choice2 = Console.ReadLine();
                            // another switch to see if you want to overwrite it or not
                            switch (choice2)
                            {
                                // if they chose yes
                                case "Y":
                                    // removes the word
                                    words.Remove(word);
                                    Console.WriteLine("Insert description");
                                    string description = Console.ReadLine();
                                    // adds the new word with a new description
                                    words.Add(word, description);
                                    Console.WriteLine("Word added");
                                    // breaks stop the switch thing and sends you back to the menu
                                    break;
                                // if they chose no
                                case "N":
                                    break;
                            }
                            break;
                        }
                        // if the word does not exist in the dictionary
                        else
                        {
                            Console.WriteLine("Insert description");
                            string description = Console.ReadLine();
                            // adds the word and description
                            words.Add(word, description);
                            Console.WriteLine("Word added");
                            break;
                        }
                    // if they chose option two (removing a word)
                    case "2":
                        Console.WriteLine("Insert word:");
                        word = Console.ReadLine();
                        // if the word exists within the dictionary
                        if (words.ContainsKey(word))
                        {
                            // it removes the word
                            words.Remove(word);
                            Console.WriteLine("Word removed");
                            break;
                        }
                        // if the word does not exist within the dictionary
                        else
                        {
                            Console.WriteLine("Word does not exist");
                            break;
                        }
                    // if they chose option three (list the words)
                    case "3":
                        // uses a foreach to read through everysingle Key and Value in the dictionary and prints them out
                        foreach (KeyValuePair<string, string> wordw in words)
                        {
                            Console.WriteLine("Word: {0} -- Description: {1}", wordw.Key, wordw.Value);
                        }
                        break;
                    // if they chose option four (the exit)
                    case "4":
                        // puts the exit to 0 ending the while loop which makes it loop back to the menu
                        exit = 0;
                        break;
                    // if they did not go withing the 1-4 range of the menu options it just sends them back to the menu
                    default:
                        break;
                }
            }
        }
    }
}
