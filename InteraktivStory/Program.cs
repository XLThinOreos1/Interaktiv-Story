using Figgle;
// Har märkt att koden funkar inte om man copypastear den här koden för den känner inte igen Thread.Sleep utan System.Threading (osäker om System är nödvändig här)
using System;
using System.Threading;
internal class Program
{
    private static void Main(string[] args)
    {
        string name;

        string answer1;

        string answer2;

        // På gravsten ascii art så skriver den in orsaken vrf du dog och den här variabeln causeOfDeath ändrar dödsorsak beroende på vilken väg man tar senare
        string causeOfDeath = "                  ";
        // SortofEnding liknar causeOfDeath där beroende på vilken väg man tar så ändrar endingen i gravsten funktionen längst ner
        string SortofEnding;

        Console.WriteLine(FiggleFonts.Stop.Render("Cool story"));
        Console.WriteLine("Press enter to start");
        Console.ReadLine();
        Console.Clear();
        // Frågar ditt namn, den räknar sen ut hur många bokstäver namnet har och sen stoppar in antalet i en uträkning som kommer användas senare i bad ending.
        Console.WriteLine("What is your name?");
        name = Console.ReadLine();
        Console.Clear();
        int length = name.Length;

        double space = (18.0 - name.Length) / 2.0;
    Start:
        Console.WriteLine(FiggleFonts.Doom.Render($"Hello {name} !"));

        Console.WriteLine(@"You are in your room playing video games on your Playstation 5 when you suddenly get hungry.
The intense hunger is bothering your gaming session so you decide it's best to eat something.
You walk out of your room towards the staircase down to the first floor
");
        // Första valet, svara med 1 eller 2. Svara med något annat så får du en elak kommentar tillbaka.
        Console.WriteLine("How do you descend down the stairs?");
        Console.WriteLine("Walk down slowly (1) ----- Run down as fast as you can (2)");
        answer1 = Console.ReadLine();
        Console.Clear();
        if (answer1 == "1")
        {
            Console.WriteLine("You successfully walked down the stairs slowly and made your way to the kitchen");
            Console.WriteLine("\nIn the kitchen you can either open the fridge or the pantry");
            Console.WriteLine("\nWhat do you choose?");
            Console.WriteLine("Open the fridge (1) ----- Look in the pantry (2) ");
            answer2 = Console.ReadLine();
            Console.Clear();
            if (answer2 == "1")
            {
                Console.WriteLine("You opened the fridge and found pizza leftovers.");
                Thread.Sleep(2000);
                Console.WriteLine("You grabbed the pizza and put it in the oven.");
                Thread.Sleep(2000);
                Console.WriteLine("Waiting...");
                Thread.Sleep(3000);
                Console.WriteLine("* DING *\nIt's done!");
                Thread.Sleep(2000);
                Console.WriteLine("You ate it and you don't feel hungry anymore. Back to gaming");
                Thread.Sleep(3000);
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine(@"
                      ██╗   ██╗ ██████╗ ██╗   ██╗    ██╗    ██╗██╗███╗   ██╗
                      ╚██╗ ██╔╝██╔═══██╗██║   ██║    ██║    ██║██║████╗  ██║
                       ╚████╔╝ ██║   ██║██║   ██║    ██║ █╗ ██║██║██╔██╗ ██║
                        ╚██╔╝  ██║   ██║██║   ██║    ██║███╗██║██║██║╚██╗██║
                         ██║   ╚██████╔╝╚██████╔╝    ╚███╔███╔╝██║██║ ╚████║
                         ╚═╝    ╚═════╝  ╚═════╝      ╚══╝╚══╝ ╚═╝╚═╝  ╚═══╝");
                Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n");
                Console.WriteLine("You got the good ending!\nFind the other two endings");
                StartOver();
            }
            else if (answer2 == "2")
            {
                Console.WriteLine("You opened the pantry and inside was nothing but a few hundred rats");
                // Skapar en liten animation av en trippel punkt loading. (., .., ...)
                for (var i = 0; i < 3; i++)
                {
                    Thread.Sleep(1500);
                    Console.Write(".");
                }
                Thread.Sleep(1500);
                Console.Write("Rats?!");
                Thread.Sleep(2000);
                Console.WriteLine("\nYou get swarmed by rats and they took over your house.");
                Thread.Sleep(3500);
                // Ändrar anledningen varför man dog och ändrar vilket slut man fick.
                causeOfDeath = "  Killed by rats  ";
                SortofEnding = "rat";
                grave();
                goto Start;
            }
        }
        else if (answer1 == "2")
        {
            Console.WriteLine(@"You ran down the stairs as fast as you could");
            Thread.Sleep(2000);
            Console.WriteLine("Your foot got stuck which caused you to be sent flying forwards");
            Thread.Sleep(4000);
            Console.WriteLine("\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n\n");
            Console.WriteLine(@"                                                    ,---,  
               ,----..            ,--.       ,--.,`--.' |  
    ,---,.    /   /   \         ,--.'|   ,--/  /||   :  :  
  ,'  .'  \  /   .     :    ,--,:  : |,---,': / ''   '  ;  
,---.' .' | .   /   ;.  \,`--.'`|  ' ::   : '/ / |   |  |  
|   |  |: |.   ;   /  ` ;|   :  :  | ||   '   ,  '   :  ;  
:   :  :  /;   |  ; \ ; |:   |   \ | :'   |  /   |   |  '  
:   |    ; |   :  | ; | '|   : '  '; ||   ;  ;   '   :  |  
|   :     \.   |  ' ' ' :'   ' ;.    ;:   '   \  ;   |  ;  
|   |   . |'   ;  \; /  ||   | | \   ||   |    ' `---'. |  
'   :  '; | \   \  ',  / '   : |  ; .''   : |.  \ `--..`;  
|   |  | ;   ;   :    /  |   | '`--'  |   | '_\.'.--,_     
|   :   /     \   \ .'   '   : |      '   : |    |    |`.  
|   | ,'       `---`     ;   |.'      ;   |,'    `-- -`, ; 
`----'                   '---'        '---'        '---`");
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine("You hit your head on the floor and you died");
            Thread.Sleep(3000);
            causeOfDeath = " Untied shoelaces ";
            SortofEnding = "fell down the stairs";
            grave();
            goto Start;
        }
        else
        {
            Console.WriteLine("You didn't answer 1 or 2... you suck.");
            Thread.Sleep(3000);
        }

        // Den här funktionen ser till att man kan starta om spelet utan att behöva starta om hela koden
        void StartOver()
        {
            Console.WriteLine("\nDo you want to start over from the beginning?\nY or N");
            // Ändrar svaret så om man skriver Y så blir det till ett litet y, samma med N
            string answer3 = Console.ReadLine();
            string answer3low = answer3.ToLower();
            if (answer3 == "y")
            {
                Console.Clear();
            }
            else if (answer3 == "n")
            {
                Console.Clear();
                Console.WriteLine($"Hejdå {name}!");
                Thread.Sleep(3000);
                Environment.Exit(0);
            }
            else
            {
                Console.WriteLine("Det var inte riktigt ett giltigt svar...okej jag kommer nu blue screena din dator");
                Thread.Sleep(4000);
                Console.WriteLine("5");
                Thread.Sleep(1000);
                Console.WriteLine("4");
                Thread.Sleep(1000);
                Console.WriteLine("3");
                Thread.Sleep(1000);
                Console.WriteLine("2");
                Thread.Sleep(1000);
                Console.WriteLine("1");
                Thread.Sleep(1000);
                Console.BackgroundColor = ConsoleColor.Blue;
                Console.Clear();
                Console.WriteLine(@"A problem has been detected and Windows has been shut down to prevent damage to your computer.

If this is the first time you've seen this stop error screen, restart your computer. if this screen appears again, follow these steps:

Check to make sure any new hardware or software is properly installed. I this is a new installation, ask your hardware or software manufacturer for and Windows updates you might need.

If problems continue, disable or remove any newly installed hardware or software. Disable BIOS memory options such as caching or shadowing. If you need to use Safe Mode to remove or disable components, restart your computer, press F8 to select Advanced Startup Options, and then select Safe Mode.

Technical information:

*** STOP: 0x000000FE (0x00000008, 0x000000006, 0x00000009, 0x847075cc)");
                Thread.Sleep(10000);
                Environment.Exit(0);
            }

        }
        void grave()
        {
            // Den här lilla grejen fixar gravsten ascii art. Om jag bara hade ascii art med namnet så skulle det leda till att sidan av gravstenen sticker ut från gravstenen och det blir fult.
            // space och space2 är antalet mellanrum som graven behöver med decimaler, vi avrundar värdena upp och ner och sätter burger till de värdena. efter det så sätter vi spaces och spaces2 till antalet mellanrum som graven behöver
            double space2 = space;
            int burger2 = (int)Math.Floor(space);
            string spaces2 = new string(' ', burger2);
            int burger = (int)Math.Ceiling(space2);
            string spaces = new string(' ', burger);
            Console.Clear();
            Console.WriteLine("\n\n\n\n\n\n");
            Console.WriteLine(@$"
                 ______
           _____/      \\_____
          |  _     ___   _   ||
          | | \     |   | \  ||
          | |  |    |   |  | ||
          | |_/     |   |_/  ||
          | | \     |   |    ||
          | |  \    |   |    ||
          | |   \. _|_. | .  ||
          |                  ||
          |{spaces}{name}{spaces2}||
          |{causeOfDeath}||
  *       | *   **    * **   |**      **
   \)),/(/,/.,(//,,..,,\||(,,.,\\,.((//");

            Console.WriteLine($"\nYou got the {SortofEnding} ending!\nFind the other two endings");
            StartOver();
        }
    }

}