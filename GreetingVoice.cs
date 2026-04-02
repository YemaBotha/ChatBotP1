using System;
using System.Collections.Generic;
using System.IO;
using System.Media;

namespace POEPar1
{
    internal class GreetingVoice
    {
        // This variable stores the full path to the wav file
        private string record;

        public GreetingVoice()
        {
            // Get the folder where the .exe is running from
            string path_directory = AppDomain.CurrentDomain.BaseDirectory;


            record = Path.Combine(path_directory, "VoiceGreeting.wav");
        }

        public void play_voice()
        {
            try
            {
                // Check the file exists before trying to play it
                if (!File.Exists(record))
                {
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine($"  [Voice file not found at: {record}]");
                    Console.ResetColor();
                    return;
                }


                SoundPlayer speechObj = new SoundPlayer(record);
                speechObj.PlaySync();
            }
            catch (Exception ex)
            {
                // If something goes wrong, show a red error message
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($" error: {ex.Message}");
                Console.ResetColor();
            }
        }
    }
}
