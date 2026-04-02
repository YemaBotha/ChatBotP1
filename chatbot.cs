using System;

namespace POEPar1
{
    internal class ChatBot
    {
        // Stores the user's name so we can personalise responses
        private string userName;

        // Constructor receives the user's name from Program.cs
        public ChatBot(string name)
        {
            userName = name;
        }

        // Start() runs the main chat loop
        public void Start()
        {
            // Show a divider and prompt to begin chatting
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine("  ");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine($"  Bot: I'm ready to chat, {userName}! You can ask any questions related to my purpose ,  password safety,phishing, and safe browsing or Type 'exit' to quit.");
            Console.ResetColor();

            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(" ");
            Console.ResetColor();
            Console.WriteLine();

            // Keep the conversation going until the user types exit
            while (true)
            {
                // Show the user's name as the prompt in yellow
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.Write($"  {userName}: ");
                Console.ResetColor();

                // Read what the user typed
                string input = Console.ReadLine();

                // Input validation: check if the user typed nothing
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("  Bot: Please type something — I'm all ears!");
                    Console.ResetColor();
                    Console.WriteLine();
                    continue; // Go back to the top of the loop
                }

                // Convert to lowercase so "Password" and "password" both work
                string lowerInput = input.ToLower().Trim();

                // Check if the user wants to exit
                if (lowerInput == "exit")
                {
                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine();
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.Cyan;
                    Console.WriteLine($"  Bot: Stay safe online, {userName}. Goodbye!");
                    Console.ResetColor();

                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                    Console.WriteLine();
                    Console.ResetColor();
                    break; // Exit the while loop
                }

                // Get the bot's response based on what the user typed
                string response = GetResponse(lowerInput);

                // Display the bot's response in magenta
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine($"  Bot: {response}");
                Console.ResetColor();
                Console.WriteLine();
            }
        }

        // GetResponse() checks what the user typed and returns the right answer
        private string GetResponse(string input)
        {
            // Basic conversational questions
            if (input.Contains("how are you"))
            {
                return $"I'm fully operational and keeping the internet safe, {userName}! How can I help you?";
            }

            if (input.Contains("what is your purpose") || input.Contains("your purpose"))
            {
                return "My purpose is to educate you about cybersecurity topics like\n"
                     + "  passwords, phishing, and safe browsing.";
            }

            if (input.Contains("what can i ask") || input.Contains("help"))
            {
                return "You can ask me about:\n"
                     + "  - What is your purpose\n"
                     + "  - Password safety\n"
                     + "  - Phishing attacks\n"
                     + "  - Safe browsing\n";

            }

            // Cybersecurity topics
            if (input.Contains("password"))
            {
                return "Use strong passwords with 12+ characters mixing uppercase,\n"
                     + "  lowercase, numbers and symbols. Never reuse the same\n"
                     + "  password across different websites.";
            }

            if (input.Contains("phishing"))
            {
                return "Phishing is when attackers send fake emails or links to\n"
                     + "  steal your information. Always check the sender's email\n"
                     + "  address and never click on suspicious links.";
            }

            if (input.Contains("browsing") || input.Contains("safe browse"))
            {
                return "For safe browsing: only use HTTPS websites, avoid public\n"
                     + "  Wi-Fi for sensitive tasks, and always keep your\n"
                     + "  browser updated to the latest version.";
            }

            // Input validation when a user ask unreleted questions about cybersecurity 
            return $"I didn't quite understand that, {userName}. Could you rephrase?\n"
                 + "  Try asking about: password, phishing, browsing, or type 'help' or exit to leave the chat.";
        }
    }
}