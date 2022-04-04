using System;
using System.Collections.Generic;
using System.Linq;

namespace Monopoly // Note: actual namespace depends on the project name.
{
    public class Program
    {

        internal static void Main(string[] args)
        {
            int playerCount = 0;

            Player player;
            Card card;
            PlayDesk playDesk = new PlayDesk();
            Dice dice = new Dice();
            UI ui = new UI();

            Console.SetWindowSize(Console.LargestWindowWidth, Console.LargestWindowHeight);

            Console.BackgroundColor = ConsoleColor.White;
            Console.ForegroundColor = ConsoleColor.Black;
            Console.Clear();


            Player playerOne = new Player();
            Player playerTwo = new Player();
            Player playerThree = new Player();
            Player playerFour = new Player();
            Player[] playerArray = { playerOne, playerTwo, playerThree, playerFour };

            Player[] activeActivePlayerArray = new Player[playerCount];
            Player[] activePlayerArray2 = new Player[2];
            Player[] activePlayerArray3 = new Player[3];
            Player[] activePlayerArray4 = new Player[4];

            //variables
            string[] rarity = new string[8];

            int price = 1000;

            /////////////////////////////////////////////////////////////////    GAME    \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            //////////////////////////////////////////////////////////////////////|\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
            bool gameIsOn = true;
            bool introNotShowed = true;

            int activePlayers = 0;

            while (gameIsOn)
            {
                while (introNotShowed)
                {
                    //calling intro for gathering number of players and their colors
                    Intro();
                    introNotShowed = false;
                }
                //determining number of active players
                for (int i = 0; i < playerArray.Length; i++)
                {
                    if (!playerArray[i].Name.ToLower().Contains("default"))
                    {
                        activePlayers++;
                    }
                }
                /////////////////////////////////////////////////////////////////   START   \\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\\
                while (gameIsOn)
                {
                    for (int i = 0; i < activePlayers; i++)
                    {
                        playDesk.AllPlayersFieldsInterface(playerArray[i]);
                        playDesk.PlayersTable(playerArray);
                        //Console.Read();
                        dice.DiceToss(playerArray[i]);
                        playDesk.AllPlayersFieldsInterface(playerArray[i]);
                        playDesk.PlayersTable(playerArray);
                        Console.ForegroundColor = ConsoleColor.Black;
                        Console.BackgroundColor = ConsoleColor.White;
                        playDesk.FieldDecission(playerArray[i]);
                        Console.Clear();
                    }
                }
            }
            Console.WriteLine("Good Game");
            void Intro()
            {
                //Number of players
                int colorChoice = 0;
                string enterNumberOfPlayers = " Enter number of players ";
                string numberOfPlayersString = "";
                string enterYourName = " Enter your name ";
                while (playerCount == 0)
                {
                    Fillers("");
                    Fillers("");
                    //enter number of players
                    Fillers(enterNumberOfPlayers);
                    //enter number of players

                    Console.SetCursorPosition(Console.WindowWidth / 2, 3);
                    try
                    {
                        //Console.WriteLine(pressNumberOfPlayers);
                        playerCount = Int32.Parse(Console.ReadLine());
                        numberOfPlayersString += String.Format(" Number of players is {0} ", playerCount);

                    }
                    catch (FormatException)
                    {
                        Console.WriteLine("Wrong input format. Please try again");
                        Console.Clear();
                    }

                    Fillers("");
                    Fillers(numberOfPlayersString);
                    Fillers("");
                    Console.ReadLine();
                    Console.Clear();

                    string[] colorChoices = { "Press 1 for BLUE", "Press 2 for GREEN", "Press 3 for MAGENTA", "Press 4 for RED" };
                    string playersChoosing = "";

                    int cursorIndex = 8;

                    for (int i = 0; i < playerCount; i++)
                    {
                        Console.ForegroundColor = ConsoleColor.Black;
                        Fillers("");
                        Fillers("");
                        Fillers(enterYourName);

                        Console.SetCursorPosition(Console.WindowWidth / 2, 3);
                        playerArray[i].Name = Console.ReadLine();

                        bool parsed = false;

                        while (!parsed)
                        {
                            playersChoosing += String.Format("Player {0} is choosing color", playerArray[i].Name);
                            Fillers(playersChoosing);
                            playersChoosing = "";

                            Console.ForegroundColor = ConsoleColor.Blue;
                            Fillers(colorChoices[0]);
                            Console.ForegroundColor = ConsoleColor.Green;
                            Fillers(colorChoices[1]);
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Fillers(colorChoices[2]);
                            Console.ForegroundColor = ConsoleColor.Red;
                            Fillers(colorChoices[3]);
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.SetCursorPosition(Console.WindowWidth / 2, 9);

                            parsed = int.TryParse(Console.ReadLine(), out colorChoice);
                            string playersColor = String.Format("{0}`s color is {1}", playerArray[i].Name, colorChoice);

                            Fillers(playersColor);
                            Console.ReadLine();
                            Console.Clear();

                            Console.ForegroundColor = ConsoleColor.Black;
                        }
                        switch (colorChoice)
                        {
                            case 1:
                                playerArray[i].Color = "Blue";
                                colorChoices[0] = String.Format("TAKEN by {0}", playerArray[i].Name);
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;

                            case 2:
                                playerArray[i].Color = "Green";
                                colorChoices[1] = String.Format("TAKEN by {0}", playerArray[i].Name);
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;

                            case 3:
                                playerArray[i].Color = "Magenta";
                                colorChoices[2] = String.Format("TAKEN by {0}", playerArray[i].Name);
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                break;

                            case 4:
                                playerArray[i].Color = "Red";
                                colorChoices[3] = String.Format("TAKEN by {0}", playerArray[i].Name);
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                                Console.ForegroundColor = ConsoleColor.Black;
                        }
                    }
                    Console.ForegroundColor = ConsoleColor.Black;
                    Console.Clear();
                }
            }
            void Fillers(string inputString)
            {
                for (int i = 0; i < Console.WindowWidth - inputString.Length; i++)
                {
                    if (i == (Console.WindowWidth / 2) - (inputString.Length / 2))
                    {
                        Console.Write(inputString);
                    }
                    if (i < Console.WindowWidth / 5 || i > Console.WindowWidth - Console.WindowWidth / 5 - inputString.Length)
                    {
                        Console.Write(" ");
                    }
                    else if (i > Console.WindowWidth / 5 || i < Console.WindowWidth - Console.WindowWidth / 5)
                    {
                        Console.Write("-");
                    }
                }
            }


            void Functions()
            {
                AddToCardList();
                void AddToCardList()
                {
                    //CardsList.Add(realEstate1);
                    //CardsList.Add(realEstate2);
                    //CardsList.Add(realEstate3);
                    //CardsList.Add(realEstate4);
                    //CardsList.Add(realEstate5);
                    //CardsList.Add(realEstate6);
                    //CardsList.Add(realEstate7);
                    //CardsList.Add(realEstate8);
                    //CardsList.Add(realEstate9);
                    //CardsList.Add(realEstate10);
                    //CardsList.Add(realEstate11);
                    //CardsList.Add(realEstate12);
                    //CardsList.Add(realEstate13);
                    //CardsList.Add(realEstate14);
                    //CardsList.Add(realEstate15);
                    //CardsList.Add(realEstate16);
                    //CardsList.Add(realEstate17);
                    //CardsList.Add(realEstate18);
                    //CardsList.Add(realEstate19);
                    //CardsList.Add(realEstate20);
                    //CardsList.Add(realEstate21);
                    //CardsList.Add(realEstate22);
                }
                //Declaring Card position
                GiveCardPosition();
                void GiveCardPosition()
                {
                    //cardArray[0].Position = 1;
                    ////community ches = 2;
                    //cardArray[1].Position = 3;

                    //railRoad.Position = 5;

                    //cardArray[2].Position = 6;
                    //cardArray[3].Position = 8;
                    //cardArray[4].Position = 9;

                    ////jail position = 10

                    //cardArray[5].Position = 11;
                    //cardArray[6].Position = 13;
                    //cardArray[7].Position = 14;

                    //railRoad2.Position = 15;

                    //cardArray[8].Position = 16;
                    //cardArray[9].Position = 18;
                    //cardArray[10].Position = 19;

                    ////parking = 20

                    //cardArray[11].Position = 21;
                    //cardArray[12].Position = 23;
                    //cardArray[13].Position = 24;

                    //railRoad3.Position = 25;

                    //cardArray[14].Position = 26;
                    //cardArray[15].Position = 27;
                    //cardArray[16].Position = 29;

                    ////jail = 30

                    //cardArray[17].Position = 31;
                    //cardArray[18].Position = 32;
                    //cardArray[19].Position = 34;

                    //railRoad4.Position = 35;

                    //cardArray[20].Position = 31;
                    //cardArray[21].Position = 32;

                }
                //DECLARING PRICES
                int[] prices = new int[22];
                DeclarePrices();
                void DeclarePrices()
                {
                    for (int i = 0; i < prices.Length; i++)
                    {
                        prices[i] = price;
                        if (i < 10)
                        {
                            price += 200;
                        }
                        else if (i > 10 && i < 15)
                        {
                            price += 150;
                        }
                        else if (i > 16)
                        {
                            price += 100;
                        }
                    }
                }
            }
        }
    }
}


