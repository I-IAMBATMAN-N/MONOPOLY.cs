using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Dice
    {
        Player player;

        Random dice = new Random();
        
        private int positionNow = 0;

        public void DiceToss(Player player)
        {
            int defaultHorizontal = Console.WindowWidth / 2;
            int defaultVertical = Console.WindowHeight / 4;

            ChangeColor(player);

            Console.SetCursorPosition(0, 0);

            //BASIC INTRO
            Console.SetCursorPosition(defaultHorizontal - (String.Format("Player {0} is playing", player.Name)).Length/2, defaultVertical);
            Console.Write(/*CardLines("PRESS ENTER")*/"Player \"{0}\" is playing", player.Name);
            Console.SetCursorPosition(defaultHorizontal - 5, Console.CursorTop + 2
                );
            Console.Write(/*CardLines("PRESS ENTER")*/"PRESS ENTER");
            Console.SetCursorPosition(defaultHorizontal, Console.CursorTop + 1);
            Console.ReadKey();


            //FIRST TOSS
            int diceToss = dice.Next(1, 6);

            int diceToss2 = dice.Next(1, 6);

            //rendering dices for player

            DiceInteraface(diceToss, diceToss2);

            Console.ReadKey();

            if (diceToss != diceToss2)
            {
                if (player.Position + (diceToss + diceToss2) >= 40)
                {
                    player.Position = (diceToss + diceToss2) - (40 - player.Position);
                }
                else if (player.Position + (diceToss + diceToss2) < 40)
                {
                    player.Position += diceToss + diceToss2;
                }
                Console.BackgroundColor = ConsoleColor.White;
            }
            //BONUS TOSS
            else if (diceToss == diceToss2)
            {
                //positionNow = diceToss + diceToss2;
                Console.SetCursorPosition(defaultHorizontal - 12, defaultVertical + 10);
                Console.WriteLine("Nice, you can toss again :)");
                Console.SetCursorPosition(defaultHorizontal - 10, Console.CursorTop + 1);
                Console.WriteLine("Press ENTER for toss");
                Console.ReadKey();

                int diceTossTwo = dice.Next(1, 6);
                int diceTossTwo2 = dice.Next(1, 6);

                DiceInteraface(diceTossTwo, diceTossTwo2);
                //JAIL DECISSION
                if (diceTossTwo != diceTossTwo2)
                {
                    player.Position += positionNow + diceTossTwo + diceTossTwo2;

                    Console.BackgroundColor = ConsoleColor.White;
                    Console.ReadLine();

                    if (player.Position + (diceToss + diceToss2) >= 40)
                    {
                        player.Position = (diceToss + diceToss2) - (40 - player.Position);
                    }
                    else if (player.Position + (diceToss + diceToss2) < 40)
                    {
                        player.Position += diceToss + diceToss2;
                    }
                }
                else if (diceTossTwo == diceTossTwo2)
                {
                    //DiceInteraface(diceTossTwo, diceTossTwo2);
                    Console.SetCursorPosition(defaultHorizontal - ("That is too much combos, you messed up. You are going to JAIL").Length / 2 , defaultVertical + 21);
                    Console.Write("That is too much combos, you messed up. You are going to JAIL");
                    //Ban(player);
                    Console.Read();
                    Console.BackgroundColor = ConsoleColor.White;
                    player.Position = 10;
                    positionNow = 0;
                }
                positionNow = 0;
            }
        }

        //INTERFACE FUNCTIONS
        public void DiceInteraface(int diceToss, int diceToss2)
        {
            string top = "  --------- ";
            string topPoint = " | o       | ";
            string topPoints = " | o     o | ";
            string middlePoint = " |    o    | ";
            string middlePoints = " | o     o | ";
            string fill = " |         | ";
            string bottomPoint = " |       o | ";
            string bottomPoints = " | o     o | ";
            string bottom = "  --------- ";

            string[] firstDice = new string[5];
            string[] secondDice = new string[5];

            //DICE1
            if (diceToss == 1)
            {
                firstDice[0] = top;
                firstDice[1] = fill;
                firstDice[2] = middlePoint;
                firstDice[3] = fill;
                firstDice[4] = bottom;
            }
            else if (diceToss == 2)
            {
                firstDice[0] = top;
                firstDice[1] = topPoint;
                firstDice[2] = fill;
                firstDice[3] = bottomPoint;
                firstDice[4] = bottom;
            }
            else if (diceToss == 3)
            {
                firstDice[0] = top;
                firstDice[1] = topPoint;
                firstDice[2] = middlePoint;
                firstDice[3] = bottomPoint;
                firstDice[4] = bottom;
            }
            else if (diceToss == 4)
            {
                firstDice[0] = top;
                firstDice[1] = topPoints;
                firstDice[2] = fill;
                firstDice[3] = topPoints;
                firstDice[4] = bottom;
            }
            else if (diceToss == 5)
            {
                firstDice[0] = top;
                firstDice[1] = topPoints;
                firstDice[2] = middlePoint;
                firstDice[3] = topPoints;
                firstDice[4] = bottom;
            }
            else if (diceToss == 6)
            {
                firstDice[0] = top;
                firstDice[1] = topPoints;
                firstDice[2] = middlePoints;
                firstDice[3] = bottomPoints;
                firstDice[4] = bottom;
            }
            //DICE2
            if (diceToss2 == 1)
            {
                secondDice[0] = top;
                secondDice[1] = fill;
                secondDice[2] = middlePoint;
                secondDice[3] = fill;
                secondDice[4] = bottom;

            }
            else if (diceToss2 == 2)
            {
                secondDice[0] = top;
                secondDice[1] = topPoint;
                secondDice[2] = fill;
                secondDice[3] = bottomPoint;
                secondDice[4] = bottom;
            }
            else if (diceToss2 == 3)
            {
                secondDice[0] = top;
                secondDice[1] = topPoint;
                secondDice[2] = middlePoint;
                secondDice[3] = bottomPoint;
                secondDice[4] = bottom;
            }
            else if (diceToss2 == 4)
            {
                secondDice[0] = top;
                secondDice[1] = topPoints;
                secondDice[2] = fill;
                secondDice[3] = topPoints;
                secondDice[4] = bottom;
            }
            else if (diceToss2 == 5)
            {
                secondDice[0] = top;
                secondDice[1] = topPoints;
                secondDice[2] = middlePoint;
                secondDice[3] = topPoints;
                secondDice[4] = bottom;
            }
            else if (diceToss2 == 6)
            {
                secondDice[0] = top;
                secondDice[1] = topPoints;
                secondDice[2] = middlePoints;
                secondDice[3] = bottomPoints;
                secondDice[4] = bottom;
            }

            int horizontalStart = Console.WindowWidth / 2 - 13;
            int verticalStart = Console.WindowHeight / 4;

            Console.SetCursorPosition(horizontalStart, Console.CursorTop + 1);
            Console.Write(firstDice[0] + "  " + secondDice[0]);

            Console.SetCursorPosition(horizontalStart, Console.CursorTop + 1);
            Console.Write(firstDice[1] + " " + secondDice[1]);

            Console.SetCursorPosition(horizontalStart, Console.CursorTop + 1);
            Console.Write(firstDice[2] + " " + secondDice[2]);

            Console.SetCursorPosition(horizontalStart, Console.CursorTop + 1);
            Console.Write(firstDice[3] + " " + secondDice[3]);

            Console.SetCursorPosition(horizontalStart, Console.CursorTop + 1);
            Console.Write(firstDice[4] + "  " + secondDice[4]);

        }
        void ChangeColor(Player player)
        {
            switch (player.Color)
            {
                case "Blue":
                    Console.ForegroundColor = ConsoleColor.Blue;
                    break;
                case "Green":
                    Console.ForegroundColor = ConsoleColor.Green;
                    break;
                case "Magenta":
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    break;
                case "Red":
                    Console.ForegroundColor = ConsoleColor.Red;
                    break;
            }
        }
        void SpareFunctions()
        {
            //string CardLines(string input)
            //{
            //    int ola = 0;
            //    int ola2 = 0;

            //    if (input.Length % 2 == 0)
            //    {
            //        ola2 = -1;
            //    }
            //    else if (input.Length % 2 == 1)
            //    {
            //        ola2 = 0;
            //    }

            //    string LeftSpaces()
            //    {
            //        string s = "|";
            //        string s2 = "";
            //        for (int i = ola; i < Console.WindowWidth / 20 - (input.Length / 2); i++)
            //        {
            //            s2 += " ";
            //        }

            //        return s + s2;
            //    }

            //    string RightSpaces()
            //    {
            //        string s = "|";
            //        string s2 = "";
            //        for (int i = ola2; i < Console.WindowWidth / 20 - (input.Length / 2); i++)
            //        {
            //            s2 += " ";
            //        }

            //        return s2 + s;
            //    }

            //    return String.Format("{0} {1} {2}", LeftSpaces(), input, RightSpaces());
            //}
        }
    }
}
