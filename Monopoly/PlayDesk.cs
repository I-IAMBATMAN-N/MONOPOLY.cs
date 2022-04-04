    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Figgle;

    namespace Monopoly
    {
    internal class PlayDesk/*: UI, IFunctions*/
    {

        CardList cardList = new CardList();

        Player player = new Player();

        Player[] playerArrayInternal = new Player[4];

        string[] fieldNames = { "START","Gray House", "CHEST", "Gray House2", "TAX", "Train Station","Blue House", "CHANCE", "Blue House2", "Blue House3", "JAIL", "Magenta House","ELECTRIC", "Magenta House2", "Magenta House3", "Train Station2", "DarkYellow House", "CHEST", "DarkYellow House2", "DarkYellow House3", "PARKING", "Red House", "CHANCE", "Red House2", "Red House3","Train Station3", "Yellow House", "Yellow House2", "WATER REPAIR","Yellow House3", "GO TO JAIL", "Green House", "Green House2", "CHEST", "Green House3", "Train Station4", "CHANCE", "Dark Blue House", "TAX", "Dark Blue House2"};

        string[] fieldNames2 = { "START", "Gray", "CHEST", "Gray", "INCOME TAX", "Train Station", "Blue", "CHANCE", "Blue", "Blue", "JAIL", "Magenta", "ELECTRIC", "Magenta", "Magenta", "Train Station2", "DarkYellow", "CHEST", "DarkYellow", "DarkYellow3", "PARKING", "Red House", "CHANCE", "Red House2", "Red", "Train Station3", "Yellow", "Yellow", "WATER REPAIR", "Yellow", "GO TO JAIL", "Green", "Green House2", "CHEST", "Green House3", "Train Station4", "CHANCE", "Dark Blue", "LUXURY TAX", "Dark Blue" };

        int price = 1000;

        int[] prices = new int[22];
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
        private const int numberOfFields = 40;
        private int Itineration { get; set; } = 0;
        public void AllPlayersFieldsInterface(/*Player[] playerArray*/Player player)
        {
            string[] fields = new string[numberOfFields];

            int k = 0;
            int fieldCount = 40;

            //Console.WriteLine(FiggleFonts.Ogre.Render("MONOPOLY"));

            int fieldsDefaultHorizontal = Console.WindowWidth / 4;
            int middleHorizontal = Console.WindowWidth / 2;

            Random random = new Random();
            //fields loop
            for (int i = 0; i < 1; i++)
            {
                int index = 0;

                Console.ForegroundColor = ConsoleColor.Black;
                if (/*playerArray[i].Name*/player.Name != "Default")
                {
                    for (int j = 0; j < 40 + 1; j++)
                    {

                        if (j <= 10)
                        {
                            bool feedback = false;
                            if (/*playerArray[i]*/player.Position == j)
                            {
                                feedback = true;
                                //send to AllPlayersInterface info
                            }
                            HorizontalField(fieldNames2[j], feedback);
                            }
                            else if (j > 10 && j < 20)
                            {
                            bool feedback2 = false;
                            if (/*playerArray[i]*/player.Position == j)
                            {
                                feedback2 = true;
                                //send to AllPlayersInterface info
                            }
                            VerticalField(fieldNames2[j],feedback2);
                        }
                        else if (j >= 20 && j <= 30)
                        {
                            bool feedback3 = false;
                            if (/*playerArray[i]*/player.Position == j)
                            {
                                feedback3 = true;
                                //send to AllPlayersInterface info
                            }
                            HorizontalField2(fieldNames2[j], feedback3);
                        }
                        else if (j > 30 && j < 40)
                        {
                            bool feedback4 = false;
                            if (/*playerArray[i]*/player.Position == j)
                            {
                                feedback4 = true;
                                //send to AllPlayersInterface info
                            }
                            VerticalField2(fieldNames2[j],feedback4);
                        }

                        Console.BackgroundColor = ConsoleColor.White;
                    }
                    k++;
                }
                Console.ForegroundColor = ConsoleColor.Black;
            }
            //Console.SetCursorPosition(middleHorizontal, 20);
        }

        int startingConsoleTop = 13;

        int itineration = 0;

        private void VerticalField(string s, bool feedback)
        {
            string space = "";
            string outputString = "";
            string filler = "";
            string edge = "";
            string house = "/\\";
            string playerFigure = "";
            string houses = "";
            string player = "";
            string playerString = "";
            string fillerString = "";
            string edgeString = "";
            string playerSpaces = "";
            string bottomEdge = "";
            string playerFigures = "";

            if (feedback)
            {
                playerFigure += "|██|";
            }

            playerFigures += playerFigure;

            if (s.Length % 2 != 0)
            {
                s += " ";
            }
            for (int j = 0; j < (18 / 2) - (s.Length/2) - 1; j++)
            {
                space += " ";
            }
            outputString = " " + space + s + space + " ";
            //edge
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                edge += " ";
            }
            //filler
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                filler += " ";
            }
            //player
            for (int i = 0; i < (18 / 2) - (playerFigures.Length / 2) - 1; i++)
            {
                playerSpaces += " ";
            }

            edgeString = " " + edge + " ";

            for (int k = 0; k < outputString.Length - 2; k++)
            {
                bottomEdge += "_"; /**/
            }

            fillerString = "│" + filler + "│";

            playerString = "│" + playerSpaces + playerFigures + playerSpaces + "│";

            string bottomString = "│" + bottomEdge + "│";

            int startingHorizontal = Console.WindowWidth / 2 + 198 / 2 - 18;

            ColorChoice(s);

            Console.SetCursorPosition(startingHorizontal, startingConsoleTop);
            Console.Write(edgeString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(outputString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(edgeString);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(playerString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(fillerString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            if (s.ToLower().Contains("yellow3"))
            {
                Console.Write(bottomString);
            }
            else
            {
                Console.Write(fillerString); 
            }

            itineration++;

            startingConsoleTop += 6;

            if (itineration >= 9)
            {
                startingConsoleTop = 13;
                itineration -= 9;
            }
        }

        int itineration2 = 0;
        int startingConsoleTop2 = 61;
        private void VerticalField2(string s, bool feedback)
        {
            string space = "";
            string outputString = "";
            string filler = "";
            string edge = "";
            string houses = "";
            string playerFigure = "";
            string playerString = "";
            string fillerString = "";
            string edgeString = "";
            string playerSpaces = "";
            string playerFigures = "";

            if (feedback)
            {
                playerFigure += "|██|";
            }
            playerFigures += playerFigure;

            if (s.Length % 2 != 0)
            {
                s += " ";
            }
            for (int j = 0; j < (18 / 2) - (s.Length / 2) - 1; j++)
            {
                space += " ";
            }
            outputString = " " + space + s + space + " ";
            //edge
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                edge += " ";
            }
            //filler
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                filler += " ";
            }
            //player
            for (int i = 0; i < (18 / 2) - (playerFigures.Length / 2) - 1; i++)
            {
                playerSpaces += " ";
            }
            edgeString = " " + edge + " ";

            fillerString = "│" + filler + "│";

            playerString = "│" + playerSpaces + playerFigures + playerSpaces + "│";

            int startingHorizontal = Console.WindowWidth / 2 - 198 / 2;

            ColorChoice(s);

            Console.SetCursorPosition(startingHorizontal, startingConsoleTop2);
            Console.Write(edgeString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(outputString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(edgeString);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(playerString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(fillerString);

            Console.SetCursorPosition(startingHorizontal, Console.CursorTop + 1);
            Console.Write(fillerString);

            startingConsoleTop2 -= 6;

            itineration2++;

            if (itineration2 >= 9)
            {
                startingConsoleTop2 = 61;
                itineration2 -= 9;
            }
        }

        int horizontalek = 0;

        int horizontalIteneration = 0;
        public void HorizontalField(string s, bool feedback)
        {
            string space = "";
            string outputString = "";

            string filler = "";
            string edge = "";
            string playerFigure = "";

            if (feedback)
            {
                playerFigure += "|██|";
            } 

            string houses = "";

            string playerString = "";
            string fillerString = "";
            string edgeString = "";
            string playerSpaces = "";
            string bottomEdge = "";
            string playerFigures = "";
            string bottomEdgeString = "";

            playerFigures += playerFigure;

            if (s.Length % 2 != 0)
            {
                s += " ";
            }
            for (int j = 0; j < (18 / 2) - (s.Length / 2) - 1; j++)
            {
                space += " ";
            }
            outputString = " " + space + s + space + " ";
            //edge
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                if (s.ToLower().Contains("start"))
                {
                    edge += "¯";/*¯*/
                }
                else
                {
                    edge += " ";/*¯*/
                }
            }
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                bottomEdge += "_"; /*_*/
            }
            //filler
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                filler += " ";
            }
            //player
            if (playerFigures.Length == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    //PlayerColorChoice();
                    playerSpaces += " ";
                }
            }
            else if(playerFigures.Length > 0)
            {
                for (int i = 0; i < (18 / 2) - (playerFigures.Length / 2) - 1; i++)
                {
                    playerSpaces += " ";
                }
            }

            edgeString = " " + edge + " ";

            bottomEdgeString = "│" + bottomEdge +"│";

            fillerString = "│" + filler + "│";

            playerString = "│" + playerSpaces + playerFigures + playerSpaces + "│";

            if (true)
            {

            }

            ColorChoice(s);

            int startingHorizontal = Console.WindowWidth / 2 - 200 / 2 + 1;

            Console.SetCursorPosition(startingHorizontal + horizontalek, 7);
            Console.Write(edgeString);

            Console.SetCursorPosition(startingHorizontal + horizontalek, Console.CursorTop + 1);
            Console.Write(outputString);

            Console.SetCursorPosition(startingHorizontal + horizontalek, Console.CursorTop + 1);
            if (s.ToLower().Contains("start"))
            {
                Console.Write(edgeString);
            }
            else
            {
                Console.Write(edgeString);
            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(startingHorizontal + horizontalek, Console.CursorTop + 1);
            Console.Write(playerString);

            ResetColor();

            Console.SetCursorPosition(startingHorizontal + horizontalek, Console.CursorTop + 1);
            Console.Write(fillerString);

            Console.SetCursorPosition(startingHorizontal + horizontalek, Console.CursorTop + 1);
            Console.Write(bottomEdgeString);

            horizontalek += 18;

            horizontalIteneration ++;

            if (horizontalIteneration == 11)
            {
                horizontalek = 0;
                horizontalIteneration = 0;
            }

        }

        int horizontalek2 = 180;

        int horizontalItineration2 = 0;


        public void HorizontalField2(string s, bool feedback)
        {
            string space = "";
            string outputString = "";

            string filler = "";
            string edge = "";

            string houses = "";

            string playerFigure = "";

            if (feedback)
            {
                playerFigure += "|██|";
            }

            string playerString = "";

            string fillerString = "";
            string edgeString = "";

            string playerSpaces = "";

            string playerFigures = "";

            string bottomEdge = "";
            string bottomEdgeString = "";

            playerFigures += playerFigure;

            if (s.Length % 2 != 0)
            {
                s += " ";
            }
            for (int j = 0; j < (18 / 2) - (s.Length / 2) - 1; j++)
            {
                space += " ";
            }
            outputString = " " + space + s + space + " ";
            //edge
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                if (s.ToLower().Contains("parking"))
                {
                    edge += " ";
                }
                else
                {
                    edge += " ";
                }
            }
            for (int k = 0; k < outputString.Length - 2; k++)
            {

                bottomEdge += "_";
            }
            //filler
            for (int k = 0; k < outputString.Length - 2; k++)
            {
                filler += " ";
            }
            //player
            if (playerFigures.Length == 0)
            {
                for (int i = 0; i < 8; i++)
                {
                    playerSpaces += " ";
                }
            }
            else if (playerFigures.Length > 0)
            {
                for (int i = 0; i < (18 / 2) - (playerFigures.Length / 2) - 1; i++)
                {
                    playerSpaces += " ";
                }
            }

            if (s.ToLower().Contains("start") || s.ToLower().Contains("parking"))
            {
                edgeString = "│" + edge + "│";
                outputString = "│" + space + s + space + "│";
            }
            else
            {
                edgeString = " " + edge + " ";
            }

            bottomEdgeString ="│" + bottomEdge + "│";

            fillerString = "│" + filler + "│";

            playerString = "│" + playerSpaces + playerFigures + playerSpaces + "│";

            if (true)
            {

            }

            int vertikalek = 0;

            int startingHorizontal = Console.WindowWidth / 2 - 198 / 2;

            ColorChoice(s);

            Console.SetCursorPosition(startingHorizontal +  horizontalek2, 67);
            Console.Write(edgeString);

            Console.SetCursorPosition(startingHorizontal  + horizontalek2, Console.CursorTop + 1);
            Console.Write(outputString);

            Console.SetCursorPosition(startingHorizontal  + horizontalek2, Console.CursorTop + 1);

            if (s.ToLower().Contains("parking"))
            {
                Console.Write(bottomEdgeString);
            }
            else
            {
                Console.Write(edgeString);

            }
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            Console.SetCursorPosition(startingHorizontal   + horizontalek2, Console.CursorTop + 1);
            Console.Write(playerString);

            ResetColor();

            Console.SetCursorPosition(startingHorizontal + horizontalek2, Console.CursorTop + 1);
            Console.Write(fillerString);

            Console.SetCursorPosition(startingHorizontal + horizontalek2, Console.CursorTop + 1);
            Console.Write(bottomEdgeString);

            horizontalek2 = horizontalek2 - 18;

            horizontalItineration2++;

            if (horizontalItineration2 == 11)
            {
                horizontalek2 = 180;
                horizontalItineration2 = 0;
            }

        }
        public void FieldDecission(Player player)
        {
            int defaultHorizontal = Console.WindowWidth / 4;
            int defaultVertical = Console.WindowHeight / 2 + 6;

            Console.SetCursorPosition(defaultHorizontal + 37, defaultVertical);

            Console.Write("<---ACTION--->");

            int buyDecission = 0;

            int controller = 0;

            //================================ CARDS ================================//
            for (int i = 0; i < cardList.cards.Count; i++)
            {
                if (player.Position == cardList.cards[i].Position)
                {
                    if (cardList.cards[i].Owner.ToLower().Contains("bank"))
                    {
                        //you can buy this card
                        Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                        Console.Write("You stepped on {0}", cardList.cards[i].Name);
                        Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);

                        Console.Write("You can buy this card => {0}", cardList.cards[i].Name);
                        Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                        Console.Write("Do you want to buy this house? => {0} for => {1}", cardList.cards[i].Name, cardList.cards[i].Price);

                        Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                        Console.Write("=> Press 1 for buy, 0 for Continue");

                        Console.SetCursorPosition(0, Console.CursorTop + 1);

                        bool passed = false;

                        while (passed == false)
                        {
                            Console.SetCursorPosition(defaultHorizontal + defaultHorizontal - 52 / 2, (Console.WindowHeight / 2) + 33);
                            Console.Write("<=<=<=<=<= Your interactions are show here =>=>=>=>=>");

                            Console.SetCursorPosition(defaultHorizontal * 2, Console.CursorTop + 1);

                            passed = int.TryParse(Console.ReadLine(), out buyDecission) && buyDecission < 2;

                            if(controller > 0)
                            {
                                if (passed != true)
                                {
                                    Console.SetCursorPosition(defaultHorizontal + defaultHorizontal - 52 / 2, Console.CursorTop + 1);
                                    Console.Write("You entered wrong input. Please try again.");
                                }
                            }
                            controller += 1;
                        }
                        controller = 0;

                        if (buyDecission == 1)
                        {
                            player.Balance -= cardList.cards[i].Price;
                            cardList.cards[i].Owner = player.Name;
                            Console.SetCursorPosition(defaultHorizontal + 37, defaultVertical + 10);
                            Console.Write("<=<=You bought this card {0}=>=>", cardList.cards[i].Name);
                            Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                            Console.Write("Your Balance after purchase: {0}", player.Balance);
                            Console.Read();
                            buyDecission = 0;
                        }
                        else if (!cardList.cards[i].Owner.ToLower().Contains("bank"))
                        {
                            for (int l = 0; l < playerArrayInternal.Length; l++)
                            {
                                if (cardList.cards[i].Owner.ToLower().Contains(playerArrayInternal[l].Name.ToLower()) && playerArrayInternal[l].Name != player.Name)
                                {
                                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 1);
                                    Console.Write("You stepped on {0}¨s RealEstate => {1}", playerArrayInternal[l].Name, cardList.cards[i].Name);
                                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);

                                    Console.Write("You will pay him rent => {0}", cardList.cards[i].Rent);
                                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                                    player.Balance -= cardList.cards[i].Rent;
                                    Console.Write("Your Balance after payment => {0}", player.Balance);

                                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 1);
                                    Console.Write("Press 1 for buy, ENTER for Continue");

                                    Console.SetCursorPosition(defaultHorizontal + defaultHorizontal - 52 / 2, (Console.WindowHeight / 2) + 33);
                                    Console.Write("<=<=<=<=<= Your interactions are show here =>=>=>=>=>");

                                    Console.SetCursorPosition(defaultHorizontal + defaultHorizontal - 1, Console.CursorTop + 2);
                                }
                            }
                        }
                    }
                }
            }
            //================================ CHEST ================================//
            if (player.Position == 2 ||player.Position == 17)
            {
                Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                Console.Write("You stepped on CHEST");

                Random random = new Random();

                int chest = random.Next(1, 6);

                int[] amounts = { 100, 200, 300, 400, 500};

                //get paid
                if (chest > 1 || chest < 3)
                {
                    if (true)
                    {
                        int index = random.Next(0, amounts.Length);
                        Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                        Console.Write("You are gonna get paid {0} from chest", amounts[index] + 1);
                        player.Balance += amounts[index];
                        Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop);
                        Console.Write("Your Balance after payment => {0}", player.Balance);
                    }
                }
                //pay
                else if (chest > 3)
                {
                    int index = random.Next(0, amounts.Length);
                    Console.Write("You are gonna pay {0}", amounts[index]);
                    player.Balance -= amounts[index];
                }
                Console.Read();
            }
            //================================ CHANCE ================================//
            else if (player.Position == 7 ||player.Position == 22)
            {
                Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                Console.Write("You stepped on CHANCE");
                Console.Read();
            }
            //================================ TAXES ================================//
            else if (player.Position == 4 || player.Position == 38)
            {
                if (player.Position == 4)
                {
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You stepped on INCOME TAX");
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You are loosing 5% of your balance");
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    player.Balance -= (player.Balance / 100) * 5;
                    Console.Write("Your balance after TAX => {0}", player.Balance);
                    Console.Read();
                }
                else
                {
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You stepped on LUXURY TAX");
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You have to pay 1000");
                    player.Balance -= 750;
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("Your Balance after TAX => {0}", player.Balance);
                    Console.Read();
                }
            }
            else if (player.Position == 12 || player.Position == 28)
            {
                if (player.Position == 12)
                {
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You stepped on ELECTRIC REPAIR");
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You have to pay 250");
                    player.Balance -= 250;
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("Your Balance after REPAIR => {0}", player.Balance);
                    Console.Read();
                }
                else
                {
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You stepped on WATER REPAIR");
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("You have to pay 350");
                    player.Balance -= 250;
                    Console.SetCursorPosition(defaultHorizontal + 37, Console.CursorTop + 2);
                    Console.Write("Your Balance after REPAIR => {0}", player.Balance);
                    Console.Read();
                }
            }
            Console.Read();
        }
        public void PlayersTable(Player[] playerArray)
        {
            Console.SetCursorPosition(0, 0);

            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;

            playerArrayInternal = playerArray;

            int defaultHorizontal = Console.WindowWidth / 2;
            int defaultVertical = Console.WindowHeight / 2 + 8;

            int playerCount = 0;

            for (int j = 0; j < playerArray.Length; j++)
            {
                if (!playerArray[j].Name.ToLower().Contains("default"))
                {
                    playerCount++;
                }
            }
            if (playerCount == 1)
            {
                defaultHorizontal += defaultHorizontal / 4;
            }
            else if (playerCount == 2)
            {
                defaultHorizontal += defaultHorizontal / 6;
            }
            else if (playerCount == 3)
            {
                defaultHorizontal += defaultHorizontal / 14;
            }

            for (int i = 0; i < playerArray.Length; i++)
            {
                if (!playerArray[i].Name.ToLower().Contains("default"))
                {
                    PlayerColorChoice(playerArray[i]);
                    Console.SetCursorPosition(defaultHorizontal, defaultVertical);
                    Console.Write("<=   PLAYER:");
                    Console.SetCursorPosition(defaultHorizontal, Console.CursorTop + 2);
                    Console.Write("<=   " + playerArray[i].Name);
                    Console.SetCursorPosition(defaultHorizontal, Console.CursorTop + 2);
                    Console.Write("<=   BALANCE:");
                    Console.SetCursorPosition(defaultHorizontal, Console.CursorTop + 2);
                    Console.Write("<=   " + playerArray[i].Balance);
                    Console.SetCursorPosition(defaultHorizontal, Console.CursorTop + 2);
                    Console.Write("<=   POSITION:");
                    Console.SetCursorPosition(defaultHorizontal, Console.CursorTop + 2);
                    Console.Write("<=   " + playerArray[i].Position);
                    defaultHorizontal += 20;
                }
            }
        }
        void ColorChoice(string s)
        {
            if (s.ToLower().Contains("gray"))
            {
                Console.BackgroundColor = ConsoleColor.Gray;
            }
            else if (s.ToLower().Contains("blue"))
            {
                Console.BackgroundColor = ConsoleColor.Blue;
            }
            else if (s.ToLower().Contains("magenta"))
            {
                Console.BackgroundColor = ConsoleColor.Magenta;
            }
            else if (s.ToLower().Contains("darkyellow"))
            {
                Console.BackgroundColor = ConsoleColor.DarkYellow;
            }
            else if (s.ToLower().Contains("red"))
            {
                Console.BackgroundColor = ConsoleColor.DarkRed;
            }
            else if (s.ToLower().Contains("yellow"))
            {
                Console.BackgroundColor = ConsoleColor.Yellow;
            }
            else if (s.ToLower().Contains("green"))
            {
                Console.BackgroundColor = ConsoleColor.DarkGreen;
            }
            else if (s.ToLower().Contains("darkblue"))
            {
                Console.BackgroundColor = ConsoleColor.DarkBlue;
            }
            else if (s.ToLower().Contains("chest"))
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
            }
            else if (s.ToLower().Contains("chance"))
            {
                Console.BackgroundColor = ConsoleColor.DarkCyan;
            }
            else if (s.ToLower().Contains("tax"))
            {
                Console.BackgroundColor = ConsoleColor.Red;
            }
            else if (s.ToLower().Contains("jail"))
            {
                Console.BackgroundColor = ConsoleColor.DarkGray;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (s.ToLower().Contains("train station"))
            {
                Console.BackgroundColor = ConsoleColor.Black;
                Console.ForegroundColor = ConsoleColor.White;
            }
            else if (s.ToLower().Contains("electric") || s.ToLower().Contains("water"))
            {
                Console.BackgroundColor = ConsoleColor.Green;
            }
            else if (s.ToLower().Contains("parking"))
            {
                Console.BackgroundColor = ConsoleColor.White;
            }
        }
        void PlayerColorChoice(Player player)
        {
            if (player.Color.ToLower().Contains("green"))
            {
                Console.ForegroundColor = ConsoleColor.Green;
            }
            else if (player.Color.ToLower().Contains("blue"))
            {
                Console.ForegroundColor = ConsoleColor.Blue;
            }
            else if (player.Color.ToLower().Contains("red"))
            {
                Console.ForegroundColor = ConsoleColor.Red;
            }
            else if (player.Color.ToLower().Contains("magenta"))
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
            }
        }
        void ResetColor()
        {
            Console.ForegroundColor = ConsoleColor.Black;
            Console.BackgroundColor = ConsoleColor.White;
        }
       
    }
}