using System;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Data;
using System.Numerics;
using System.Runtime.CompilerServices;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Bring_Back_The_Light
// i copied typewrite effect from here http://programmingisfun.com/typewriter-effect/
// i got aliens art from https://www.asciiart.eu/
// game title ASCII text generated  from https://textkool.com/en/ascii-art-generator?hl=default&vl=default&font=Red%20Phoenix&text=Your%20text%20here%20
// i got riddles from https://www.riddles.nu/letter-riddles/
{
    public class Game
    {
        Player player = new Player();

        Level DarkField = new Level();
        Level SorrowLand = new Level();
        Level Void = new Level();
        Level StoneForest = new Level();
        Level BrightestRoad = new Level();

        List<Level> Levels = new List<Level>();

        Enemy Grodus = new Enemy()
        {
            Name = "Grodus",



        };

        public Game()
        {


        }


        public int Stars { get; private set; }
        public object Power { get; private set; }

        static void Typewrite (string message)
        {
            for (int i = 0; i < message.Length; i++)
            {
                Console.Write(message[i]);
                System.Threading.Thread.Sleep(60);
            }
        }

        //static void Main()
        //{
        //    string txt = "Looking for DEFENDER!";
        //    while (true)
        //    {
        //        WriteBlinkingText(txt, 500, true);
        //        WriteBlinkingText(txt, 500, false);
        //    }
        //}

        //private static void WriteBlinkingText(string text, int delay, bool visible)
        //{
        //    if (visible)
        //        Console.Write(text);
        //    else
        //        for (int i = 0; i < text.Length; i++)
        //            Console.Write(" ");
        //    Console.CursorLeft -= text.Length;
        //    System.Threading.Thread.Sleep(delay);
        //}


        public void Start()
        {
            Collectibles M = new Collectibles("M");
            Collectibles A = new Collectibles("A");
            Collectibles G = new Collectibles("G");
            Collectibles I = new Collectibles("I");
            Collectibles C = new Collectibles("C");

            DarkField.Name = "Dark Field";
            DarkField.Description = "This is the first level. Start of the journey. Be ready for some tricky questions and don't loose your mind.";
            DarkField.Collectibles.Add(M);

            SorrowLand.Name = "Sorrow Land";
            SorrowLand.Description = "This is the second level. It might get harder. Be considerate.";
            SorrowLand.Collectibles.Add(A);

            Void.Name = "Void";
            Void.Description = "This is the third level. Don't get tricked with this one.";
            Void.Collectibles.Add(G);

            StoneForest.Name = "Stone Forest";
            StoneForest.Description = "This is the fourth level. We are so close to the end! Remember about your goal";
            StoneForest.Collectibles.Add(I);

            BrightestRoad.Name = "Brightest Road";
            BrightestRoad.Description = "This is the fifth level. The last one. We are so cloe to the victory!";
            BrightestRoad.Collectibles.Add(C);

 

            Console.Title = "Bring Back The Light";

            Console.WriteLine("You recieved a message. Press any key to open it.");
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine(@"
    _     _____  _____ _   _______ _   _ _____  ______ ___________  ______ ___________ _____ _   _______ ___________    
   | |   |  _  ||  _  | | / /_   _| \ | |  __ \ |  ___|  _  | ___ \ |  _  \  ___|  ___|  ___| \ | |  _  \  ___| ___ \   
   | |   | | | || | | | |/ /  | | |  \| | |  \/ | |_  | | | | |_/ / | | | | |__ | |_  | |__ |  \| | | | | |__ | |_/ /   
   | |   | | | || | | |    \  | | | . ` | | __  |  _| | | | |    /  | | | |  __||  _| |  __|| . ` | | | |  __||    /    
   | |___\ \_/ /\ \_/ / |\  \_| |_| |\  | |_\ \ | |   \ \_/ / |\ \  | |/ /| |___| |   | |___| |\  | |/ /| |___| |\ \    
   \_____/\___/  \___/\_| \_/\___/\_| \_/\____/ \_|    \___/\_| \_| |___/ \____/\_|   \____/\_| \_/___/ \____/\_| \_|   ");
            Console.ReadKey();
            Console.Clear();


            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.Blue;
            Console.Clear();

            Console.WriteLine(@"
                                                      \___/
                                                     /     \
                                                    ( ^   ^ )
                                                     \__O__/
                                                      _| |_ /
                                                     <|___|/
                                                      |___|
                                                     /     \
                                                     \     /");
            Typewrite("You are the chosen one.");
            Console.WriteLine();
            Typewrite("Throughout all people on Earth, you met our requirements and the only one who can help us to save our planet Manides.");
            Console.WriteLine();
            Typewrite("Do you want to help us and become a hero of the entire Falling Galaxy? Yes or No?");
            Console.WriteLine();

            string yesNoResponse = Console.ReadLine().Trim().ToLower();
            if (yesNoResponse == "yes")
            {


                Console.WriteLine(@"
             ____       _               _                _      _   _            _ _       _     _   
            |  _ \     (_)             | |              | |    | | | |          | (_)     | |   | |  
            | |_) |_ __ _ _ __   __ _  | |__   __ _  ___| | __ | |_| |__   ___  | |_  __ _| |__ | |_ 
            |  _ <| '__| | '_ \ / _` | | '_ \ / _` |/ __| |/ / | __| '_ \ / _ \ | | |/ _` | '_ \| __|
            | |_) | |  | | | | | (_| | | |_) | (_| | (__|   <  | |_| | | |  __/ | | | (_| | | | | |_ 
            |____/|_|  |_|_| |_|\__, | |_.__/ \__,_|\___|_|\_\  \__|_| |_|\___| |_|_|\__, |_| |_|\__|
                                 __/ |                                                __/ |          
                                |___/                                                |___/           ");


                Console.WriteLine("Press any key to start...");
                Console.ReadKey();

                Console.Clear();

                Console.WriteLine("Alright, defender, what is your name?");
                player.Name = Console.ReadLine();

                Console.Clear();

                Console.WriteLine($"Hello {player.Name}, let me tell you the story...");

                Console.WriteLine(@"
                                                      \___/
                                                     /_   _\
                                                    ( .   . )
                                                     \__~__/
                                                      _| |_ 
                                                     ||___||
                                                      |___|
                                                      |   |
                                                      |   |");


                Typewrite("It began during the war on Manides planet, after which enemies use a massive explosion attack that cancelled gravity.");
                Console.WriteLine();
                Typewrite("It caused all stars to fall from the sky and Grodus stole all of them.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.BackgroundColor = ConsoleColor.Black;
                Typewrite("Now there is forever darkness.");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Black;
                Console.BackgroundColor = ConsoleColor.Blue;
                Typewrite("Every peaceful citizen on the planet is wishing for the light to come back.");
                Console.WriteLine();
                Typewrite("You need to fight Grodus and get back stars that he stole in order to save Manides.");
                Console.WriteLine();
                Typewrite("Ready? There is no way back. Press any key to continue.");
                Console.WriteLine();
                Console.ReadLine();
                Console.Clear();
                ChooseRace();
                Console.ReadKey();
                Console.Clear();
            }





            else
            {
                Console.WriteLine(@"
                                                      \___/
                                                     /     \
                                                    ( T   T )
                                                     \__-__/
                                                      _| |_ 
                                                     <|___|>
                                                      |___|
                                                      |   |
                                                      |   |
                                      Well... we will find someone better then...
");

            
            }
        }
        

            public void ChooseRace()

            {
            Race Anteno = new Race()
            {
                Name = "Anteno",
                Description = "Anteno is the race with the highest intelligence."

            };

            Race Pixi = new Race()
            {
                Name = "Pixi",
                Description = "Pixis are the tiny and clever race."
            };


            Race Gulp = new Race()
            {
                Name = "Gulp",
                Description = "Gulps are clumsy, but have better luck in guessing."
            };

            Console.WriteLine("What Race would you like to choose for your character?");
            
            Console.WriteLine("Type a number for a race to read the description.");
                Console.WriteLine(@"

 o            o                ___
  \          /             ___/   \___
   \        /             /   '---'   \           _________
    :-'""'-:              '--_______--'          /___   ___\
 .-'  ____  `-.                / \              //aaa\ /aaa\\
( (  (_()_)  ) )              /   \             \\aaa/ \aaa//
 `-.   ^^   .-'               /\O/\               \__ * __/
    `._==_.'                  / | \                 | - |
     __)(___    Anteno - 1    // \\     Pixi - 2    \ _ /    Gulp - 3");


            //for the riddle code i was inspired by video https://www.youtube.com/watch?v=8m9SEkkbK3I
            string choice = Console.ReadLine();
                switch (choice)
                {
                    case "1":
                        player.Race = "Anteno";
                        Console.WriteLine($"Smart choice, {player.Name}! You are now one of the {Anteno.Name}. {Anteno.Description}");
                        break;
                    case "2":
                        player.Race = "Pixi";
                        Console.WriteLine($"Good choice, {player.Name}! You are now one of the {Pixi.Name}. {Pixi.Description}");
                        break;
                    case "3":
                        player.Race = "Gulp";
                        Console.WriteLine($"Funny guy, {player.Name}! You are now one of the {Gulp.Name}. {Gulp.Description}");
                        break;

                }

                if (choice == "1")
            {
                Console.WriteLine("Now, lets save our planet....NO, ENTIRE FALLEN GALAXY!!!");
                Console.WriteLine($"You will have {player.Hearts} hearts from the beginning.");
                Console.WriteLine($"Your enemy {Grodus.Name} will have {Grodus.Power} power points.");
                Console.WriteLine("Your goal is to collect 5 stars and special secret skill in order to bring back the light and win the game.");
                Console.WriteLine($"Be careful, with every mistake {Grodus.Name} can steal your health and increase his power.");
                Console.WriteLine("If you run out of your hearts - you will loose the game.");
                Console.WriteLine($"And remember. Listen carefully to every advice throughout your journey, we are counting on you, {player.Name}!");

                Console.ReadKey();
                Console.Clear();
                    playRound();
                }
                else if (choice == "2")
                {
                    Console.WriteLine("Now, lets save our planet....NO, ENTIRE FALLEN GALAXY!!!");
                Console.WriteLine($"You will have {player.Hearts} hearts from the beginning.");
                Console.WriteLine($"Your enemy {Grodus.Name} will have {Grodus.Power} power points.");
                Console.WriteLine("Your goal is to collect 5 stars and special secret skill in order to bring back the light and win the game.");
                Console.WriteLine($"Be careful, with every mistake {Grodus.Name} can steal your health and increase his power.");
                Console.WriteLine("If you run out of your hearts - you will loose the game.");
                Console.WriteLine($"And remember. Listen carefully to every advice throughout your journey, we are counting on you, {player.Name}!");
                Console.ReadKey();
                Console.Clear();
                playRound();
                }
                else if (choice == "3")
                {
                    Console.WriteLine("Now, lets save our planet....NO, ENTIRE FALLEN GALAXY!!!");
                Console.WriteLine($"You will have {player.Hearts} hearts from the beginning.");
                Console.WriteLine($"Your enemy {Grodus.Name} will have {Grodus.Power} power points.");
                Console.WriteLine("Your goal is to collect 5 stars and special secret skill in order to bring back the light and win the game.");
                Console.WriteLine($"Be careful, with every mistake {Grodus.Name} can steal your health and increase his power.");
                Console.WriteLine("If you run out of your hearts - you will loose the game.");
                Console.WriteLine($"And remember. Listen carefully to every advice throughout your journey, we are counting on you, {player.Name}!");
                Console.ReadKey();
                Console.Clear();
                playRound();
                }
                else
                {
                    Console.WriteLine("That is not a valid number, please, choose your race and type number 1,2 or 3");
                Console.ReadLine();
                Console.Clear();
                ChooseRace();
                Console.ReadKey();
                Console.Clear();
            }


        }
        

 
    
    
        public void Win()
        {
            Stars = Stars + 1;
            Console.WriteLine("You win!");
            Console.WriteLine($"Stars collected:{Stars}.");
            Grodus.Power--;
            Console.WriteLine($"You lowered {Grodus.Name}'s power. Now it is {Grodus.Power}.");


        }

        public void Lose()
        {

            Console.WriteLine("You loose!");
            Console.WriteLine($"Your enemy {Grodus.Name} just stole your health!");
            player.Hearts--;
            Grodus.Power++;
            Console.WriteLine($"Hearts left:{player.Hearts}.");
            Console.WriteLine($"{Grodus.Name} power:{Grodus.Power}");



        }

        void GameOver()
        {
            Console.BackgroundColor= ConsoleColor.Red;
            Console.WriteLine("You ran out of hearts. You LOST!");
            Console.WriteLine("Would you like to play again?");
            string yesNoResponse = Console.ReadLine().Trim().ToLower();
            if (yesNoResponse == "yes")
            {
                Start();
            }
            else
            {
                Environment.Exit(0);
            }
        }

        public void AskToPlayAgainRound()
        {
            if (player.Hearts > 0)
            {
                Console.WriteLine("Would you like to try again? Yes or no?");
                string yesNoResponse = Console.ReadLine().ToLower().Trim();
                if (yesNoResponse == "yes")
                {
                    if (player.Hearts == 3)
                    {
                        playRound();
                    }
                    else if (player.Hearts == 1)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.)");

                            Console.WriteLine("Pay attention to the word MoMent...");
                        Console.ReadKey();
                        Console.Clear();
                        playRound();
                    }
                    else if (player.Hearts ==2)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.");
                       
                        Console.WriteLine("Pay attention to the word MoMent...");

                        Console.ReadKey();
                        Console.Clear();
                        playRound();

                    }
                   

                    }
                else
                {
                    Console.WriteLine("Sad... You just missed one star. Who knows, that might be crucial by the end...");
                    PlayRound2();
                }
            }
            else
            {
                GameOver();
            }
           

        }

        public void AskToPlayAgainRound2()
        {
            if (player.Hearts > 0)
            {
                Console.WriteLine("Would you like to try again? Yes or no?");
                string HintResponse = Console.ReadLine().ToLower().Trim();
                if (HintResponse == "yes")
                {
                    if (player.Hearts == 3)
                    {
                        PlayRound2();
                    }
                    else if (player.Hearts == 1)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.)");

                        if (HintResponse == "yes")
                        {
                            Console.WriteLine("What wAter and Air has in common...");
                            Console.ReadKey();
                            Console.Clear();
                            PlayRound2();
                        }
                        else
                        {
                            PlayRound2();
                        }
                    }
                    else if (player.Hearts == 2)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.");

                       
                        Console.WriteLine("What wAter and Air has in common...");
                        Console.ReadKey();
                        Console.Clear();
                        PlayRound2();
                    }


                }
                else
                {
                    Console.WriteLine("Sad... You just missed one star. Who knows, that might be crucial by the end...");
                    PlayRound3();
                }
            }
            else
            {
                GameOver();
            }


        }

        public void AskToPlayAgainRound3()
        {
            if (player.Hearts > 0)
            {
                Console.WriteLine("Would you like to try again? Yes or no?");
                string yesNoResponse = Console.ReadLine().ToLower().Trim();
                if (yesNoResponse == "yes")
                {
                    if (player.Hearts == 3)
                    {
                        PlayRound3();
                    }
                    else if (player.Hearts == 1)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.)");

                        
                        Console.WriteLine("Don't overthink. The answer is right in the question.");

                        Console.ReadKey();
                        Console.Clear();
                        PlayRound3();

                    }
                    else if (player.Hearts == 2)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you. Do you want it? (yes/no)");

                        if (yesNoResponse == "yes")
                        {
                            Console.WriteLine("Don't overthink. The answer is right in the question.");
                            Console.ReadKey();
                            Console.Clear();
                            PlayRound3();   
                        }
                        else
                        {
                            PlayRound3();
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Sad... You just missed one star. Who knows, that might be crucial by the end...");
                    PlayRound4();
                }
            }
            else
            {
                GameOver();
            }


        }

        private void AskToPlayAgainRound4()
        {
            if (player.Hearts > 0)
            {
                Console.WriteLine("Would you like to try again? Yes or no?");
                string yesNoResponse = Console.ReadLine().ToLower().Trim();
                if (yesNoResponse == "yes")
                {
                    if (player.Hearts == 3)
                    {
                        PlayRound4();
                    }
                    else if (player.Hearts == 1)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.)");

                       
                        Console.WriteLine("Try to say out loud every part of your face (not in the plural). Write what is sounds like!");
                        Console.ReadKey();
                        Console.Clear();
                        PlayRound4();   

                    }
                    else if (player.Hearts == 2)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.");

                       
                        Console.WriteLine("Try to say out loud every part of your face (not in the plural). Write what is sounds like!");
                        Console.ReadKey();
                        Console.Clear();
                        PlayRound4();   

                    }


                }
                else
                {
                    Console.WriteLine("Sad... You just missed one star. Who knows, that might be crucial by the end...");
                    PlayRound5();
                }
            }
            else
            {
                GameOver();
            }


        }

        private void AskToPlayAgainRound5()
        {
            if (player.Hearts > 0)
            {
                Console.WriteLine("Would you like to try again? Yes or no?");
                string yesNoResponse = Console.ReadLine().ToLower().Trim();
                if (yesNoResponse == "yes")
                {
                    if (player.Hearts == 3)
                    {
                        PlayRound5();
                    }
                    else if (player.Hearts == 1)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.");

                       
                        Console.WriteLine("There is an ocean... There is a lake... There is a river... But how about [sea]?");
                        Console.ReadKey();
                        Console.Clear();
                        PlayRound5();   

                    }
                    else if (player.Hearts == 2)
                    {
                        Console.WriteLine($"Hey {player.Name} you got only {player.Hearts} left. I have a hint for you.");

                        if (yesNoResponse == "yes")
                        {
                            Console.WriteLine("There is an ocean... There is a lake... There is a river... But how about [sea]?");
                            Console.ReadKey();
                            Console.Clear();
                            PlayRound5();   
                        }
                        else
                        {
                            PlayRound5();
                        }
                    }


                }
                else
                {
                    Console.WriteLine("Sad... You just missed one star. Who knows, that might be crucial by the end...");
                    PlayRound5();
                }
            }
            else
            {
                GameOver();
            }


        }

        public void playRound()
        {

            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(@"
  ____    _    ____  _  __  _____ ___ _____ _     ____  
 |  _ \  / \  |  _ \| |/ / |  ___|_ _| ____| |   |  _ \ 
 | | | |/ _ \ | |_) | ' /  | |_   | ||  _| | |   | | | |
 | |_| / ___ \|  _ <| . \  |  _|  | || |___| |___| |_| |
 |____/_/   \_\_| \_\_|\_\ |_|   |___|_____|_____|____/ ");
            Console.WriteLine();
            Console.WriteLine($"{DarkField.Description}");

            Console.ReadKey();
            Console.Clear();



            

            Console.WriteLine("What comes once in a minute, twice in a moment, but never in a thousand years?");

            string playResponse = Console.ReadLine().Trim().ToLower();

            if (playResponse == "m")
            {
                Console.WriteLine("You guessed...");
                Win();
                //Console.WriteLine($"You collected letter {DarkField.Collectibles[0].Name}.");
                player.AddCollectiblesToInventory(DarkField.Collectibles[0]);
                PlayRound2();

            }
            else
            {
                Console.WriteLine("That wasn't smart of you... Think harder.");
                Lose();

                AskToPlayAgainRound();
            }

            Console.ReadLine();
            Console.Clear();



        }


        private void PlayRound2()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Look at you!!!");
            Console.WriteLine("Let's continue our journey.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
  ____   ___  ____  ____   _____        __  _        _    _   _ ____  
 / ___| / _ \|  _ \|  _ \ / _ \ \      / / | |      / \  | \ | |  _ \ 
 \___ \| | | | |_) | |_) | | | \ \ /\ / /  | |     / _ \ |  \| | | | |
  ___) | |_| |  _ <|  _ <| |_| |\ V  V /   | |___ / ___ \| |\  | |_| |
 |____/ \___/|_| \_\_| \_\\___/  \_/\_/    |_____/_/   \_\_| \_|____/ ");
            Console.WriteLine();
            Console.WriteLine($"{SorrowLand.Description}");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("I'm in water, in air, in animals\r\nWhile I am in air, I am not in oxygen.\r\nI am also in water, but not in hydrogen.\r\nI am necessary in all animals, but you won't find me in the zoo.\r\nLook in all brains and you'll find me there too.\r\n\r\nWhat am I?");

            string playResponse2 = Console.ReadLine().Trim().ToLower();

            if (playResponse2 == "a")
            {
                Console.WriteLine("You guessed...");
                Win();
                //Console.WriteLine($"You collected letter {SorrowLand.Collectibles[0].Name}.");
                player.AddCollectiblesToInventory(SorrowLand.Collectibles[0]);
                PlayRound3();

            }
            else
            {
                Console.WriteLine("That wasn't smart of you... Think harder.");
                Lose();
                AskToPlayAgainRound2();


            }
        }

        public void PlayRound3()
        {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkRed;
            Console.WriteLine("Look at you!!!");
            Console.WriteLine("Let's continue our journey.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
 __     _____ ___ ____  
 \ \   / / _ \_ _|  _ \ 
  \ \ / / | | | || | | |
   \ V /| |_| | || |_| |
    \_/  \___/___|____/ ");
            Console.WriteLine();
            Console.WriteLine($"{Void.Description}");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What always ends everything?");

            string playResponse2 = Console.ReadLine().Trim().ToLower();

            if (playResponse2 == "g")
            {
                Console.WriteLine("You guessed...");
                Win();
                //Console.WriteLine($"You collected letter {Void.Collectibles[0].Name}.");
                player.AddCollectiblesToInventory(Void.Collectibles[0]);
                PlayRound4();
            }
            else
            {
                Console.WriteLine("That wasn't smart of you... Think harder.");
                Lose();
                AskToPlayAgainRound3();

            }

        }

            public void PlayRound4()
            {
            Console.ForegroundColor = ConsoleColor.White;
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine("Look at you!!!");
                Console.WriteLine("Let's continue our journey.");
                Console.ReadKey();
                Console.Clear();
                Console.WriteLine(@"
  ____ _____ ___  _   _ _____   _____ ___  ____  _____ ____ _____ 
 / ___|_   _/ _ \| \ | | ____| |  ___/ _ \|  _ \| ____/ ___|_   _|
 \___ \ | || | | |  \| |  _|   | |_ | | | | |_) |  _| \___ \ | |  
  ___) || || |_| | |\  | |___  |  _|| |_| |  _ <| |___ ___) || |  
 |____/ |_| \___/|_| \_|_____| |_|   \___/|_| \_\_____|____/ |_|   ");
            Console.WriteLine();
                Console.WriteLine($"{StoneForest.Description}");
                Console.ReadKey();
                Console.Clear();

                Console.WriteLine("What letter is a part of the head?");

                string playResponse2 = Console.ReadLine().Trim().ToLower();

                if (playResponse2 == "i")
                {
                    Console.WriteLine("You guessed...");
                    Win();
                //Console.WriteLine($"You collected letter {StoneForest.Collectibles[0].Name}.");
                player.AddCollectiblesToInventory(StoneForest.Collectibles[0]);
                PlayRound5();
                

                }
                else
                {
                    Console.WriteLine("That wasn't smart of you... Think harder.");
                    Lose();
                    AskToPlayAgainRound4();

                }

            }

        private void PlayRound5()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.BackgroundColor = ConsoleColor.White;
            Console.WriteLine("Look at you!!!");
            Console.WriteLine("Let's continue our journey.");
            Console.ReadKey();
            Console.Clear();
            Console.WriteLine(@"
  ____  ____  ___ ____ _   _ _____ _____ ____ _____   ____   ___    _    ____  
 | __ )|  _ \|_ _/ ___| | | |_   _| ____/ ___|_   _| |  _ \ / _ \  / \  |  _ \ 
 |  _ \| |_) || | |  _| |_| | | | |  _| \___ \ | |   | |_) | | | |/ _ \ | | | |
 | |_) |  _ < | | |_| |  _  | | | | |___ ___) || |   |  _ <| |_| / ___ \| |_| |
 |____/|_| \_\___\____|_| |_| |_| |_____|____/ |_|   |_| \_\\___/_/   \_\____/ ");
            Console.WriteLine();
            Console.WriteLine($"{BrightestRoad.Description}");

            Console.ReadKey();
            Console.Clear();

            Console.WriteLine("What letter is a body of water?");

            string playResponse2 = Console.ReadLine().Trim().ToLower();

            if (playResponse2 == "c")
            {
                Console.WriteLine("You guessed...");
                Win();
                //Console.WriteLine($"You collected letter {BrightestRoad.Collectibles[0].Name}.");
                player.AddCollectiblesToInventory(BrightestRoad.Collectibles[0]);
                Console.ReadKey();
                Console.Clear();
                Summary();
  
                

            }
            else
            {
                Console.WriteLine("That wasn't smart of you... Think harder.");
                Lose();
                AskToPlayAgainRound5();

            }
        }



        public void Summary()
        {
           
            Console.WriteLine("The journey was rough. But look at the stats!");
            Console.WriteLine($"Your hearts: {player.Hearts}.");
            Console.WriteLine($"{Grodus.Name} power:{Grodus.Power}");
                
                Console.WriteLine("Press any key to continue.");
                Console.ReadLine();

                End();

            
        }

       

        public void End()
        {
            
            
            if (Stars == 5)
            {
                Console.WriteLine($"You collected {player.Inventory.Count}  letters.");
                foreach (var collectibles in player.Inventory)
                {
                    Console.WriteLine($"{collectibles.Name}");
                }
                Console.WriteLine("Now, that you unlocked this skill, you can BRING BACK THE LIGHT!");
                Console.WriteLine($"Congratulations, {player.Name}. You finished all levels and collected {Stars} stars. Let's see how our sky looks like!");
                Console.WriteLine(@"
                   *       '
              *                *


                     .
         .                     ;
                           - --+- -                               
                    .          !
                 .             .


   *   '*
           *
                *
                       *
               *
                     *

         .                      .
         .                      ;
         :                  - --+- -
         !           .          !
         |        .             .
         |_         +
      ,  | `.
--- --+-<#>-+- ---  --  -
      `._|_,'
         T
         |
         !
         :         . : 
         .       *     ");

                
            }
            else
            {
                Console.WriteLine("Sadly, stars that you collected were not enough to light up the sky... You didn't save us and now we have to know how to survive in darknes...");
            }
        }



    }


}

            

            

            


    

