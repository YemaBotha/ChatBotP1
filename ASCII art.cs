using System;

namespace POEPar1
{
    internal class ASCII_art
    {
        public ASCII_art()
        {


            // Set the text colour to cyan for the header
            Console.ForegroundColor = ConsoleColor.Cyan;

            // Display the ASCII art logo as the title screen
            Console.WriteLine(@"                                    /¯¯\
                  \__/
                   ||
                   ||
                  |  |
                  |  |
                  |  |
                  |  |
                  |  |
                  |  |
              .--.----.--.
            .-----\__/-----.
    ___---¯¯////¯¯|\/|¯¯\\\\¯¯---___
 /¯¯ __O_--////   |  |   \\\\--_O__ ¯¯\
| O?¯      ¯¯¯    |  |    ¯¯¯      ¯?O | 
|  '    _.-.      |  |      .-._    '  |
|O|    ?..?      ./  \.      ?..?    |O|
| |     '?. .-.  | /\ |  .-. .?'     | |
| ---__  ¯?__?  /|\¯¯/|\  ?__?¯  __--- |
|O     \         ||\/ |         /     O|
|       \  /¯?_  ||   |  _?¯\  /       |
|       / /    - ||   | -    \ \       |
|O   __/  | __   ||   |   __ |  \__   O|
| ---     |/  -_/||   |\_-  \|     --- | 
|O|            \ ||   | /            |O|  
\ '              ||   |        ^~DLF ' /
 \O\    _-¯?.    ||   |    .?¯-_    /O/
  \ \  /  /¯¯¯?  ||   |  ?¯¯¯\  \  / /
   \O\/   |      ||   |      |   \/O/
    \     |      ||   |      |     /
     '.O  |_     ||   |     _|  O.'
        '._O'.__/||   |\__.'O_.'
           '._ O ||   | O _.'
              '._||   |_.'
                 ||   |
                 ||   |
                 | \/ |
                 |  | |
                  \ |/
                   \/            

   _   _   _   _   _   _   _     _   _   _     _   _   _   _  
  / \ / \ / \ / \ / \ / \ / \   / \ / \ / \   / \ / \ / \ / \ 
 ( K | E | E | P | I | N | G ) ( Y | O | U ) ( S | A | F | E )
  \_/ \_/ \_/ \_/ \_/ \_/ \_/   \_/ \_/ \_/   \_/ \_/ \_/ \_/ 
   _   _     _   _   _   _   _   _   _     _   _   _   _   _  
  / \ / \   / \ / \ / \ / \ / \ / \ / \   / \ / \ / \ / \ / \ 
 ( I | N ) ( D | I | G | I | T | A | L ) ( W | O | R | L | D )
  \_/ \_/   \_/ \_/ \_/ \_/ \_/ \_/ \_/   \_/ \_/ \_/ \_/ \_/ 

"


);

            // Reset colour back to default after the header
            Console.ResetColor();
            Console.WriteLine();
        }
    }
}