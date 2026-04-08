using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POEPar1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Show the ASCII art title screen
            ASCII_art artObj = new ASCII_art();

            // Play the recorded voice greeting
            GreetingVoice greetingObj = new GreetingVoice();
            greetingObj.play_voice();

            // Display a text welcome message
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("  Welcome to the Cybersecurity Awareness Bot!     ");
            Console.ResetColor();
            Console.WriteLine();

            // Ask the user for their name
            string userName = "";

            while (string.IsNullOrWhiteSpace(userName))
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write("  Please enter your name: ");
                Console.ResetColor();
                userName = Console.ReadLine();

                // If the user pressed Enter without typing, show message and ask again
                if (string.IsNullOrWhiteSpace(userName))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Please enter the needed info to proceed.");
                    Console.ResetColor();
                    Console.WriteLine();
                }
            }

            // Show a personalised greeting using their name
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine($"  Hello, {userName}! Great to have you on board.");
            Console.ResetColor();
            Console.WriteLine();

            // Start the chatbot conversation
            ChatBot bot = new ChatBot(userName);
            bot.Start();
        }
    }
}
