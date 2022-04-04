using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Player
    {
        public string Name { get; set; }
        public string Color { get; set; }
        public int Level { get; set; }
        public int Balance { get; set; }
        public int Position { get; set; } = 0;

        //enumerator for player actual status
        //public bool playerActive = true; 

        public List<Card> playerInventory = new List<Card>();
        private List<RealEstate> realEstateList = new List<RealEstate>();
        public Player(string Name)
        {
            this.Name = Name;
        }
        public Player()
        {
            Name = "Default";
            Color = "Default";
            Level = 1;
            Balance = 15000;
            Position = 0;
        }
        public Player(string Name, string Color, int Level, int Balance, int Position)
        {
            this.Name = Name;
            this.Color = Color;
            this.Level = Level;
            this.Balance = Balance;
            this.Position = Position;
        }
        public void ChangePlayerColor()
        {
            switch (Color)
            {
                case "brown":
                    Console.BackgroundColor = ConsoleColor.Blue;
                    break;
                case "blue":
                    Console.BackgroundColor = ConsoleColor.Green;
                    break;
                case "magenta":
                    Console.BackgroundColor = ConsoleColor.Magenta;
                    break;
                case "darkyellow":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "yellow":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "green":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
                case "darkBlue":
                    Console.BackgroundColor = ConsoleColor.Red;
                    break;
            }
        }
        void SpareFunctions()
        {

            //public void Ban(Player player)
            //{

            //}
            //public void BuyCard(Card card)
            //{
            //    playerInventory.Add(card);
            //    Console.WriteLine("Card {0} added to {1} player inventory", card.Name, Name);
            //    card.Owner = Name;
            //    //using adjust balance method
            //    AdjustBalance(card.Price);
            //    playerInventory.Add(card);
            //}

            //public void PayAnotherPlayer(Player player2, Card card)
            //{
            //    Console.WriteLine("Card rent = {0}", card.Rent);
            //    Balance -= card.Rent;
            //    Console.WriteLine("Player balance {0} - {1} = {2}", Balance, card.Rent, Balance - card.Rent);
            //    player2.Balance += card.Rent;
            //}
            //public void AdjustBalance(int input)
            //{
            //    Console.WriteLine("Your balance {0} - {1}", Balance, input);
            //    Balance -= input;
            //    Console.WriteLine("Balance after payment {0}", Balance);
            //    Console.ReadKey();
            //}
            //public void ShowPlayersInventory()
            //{
            //    int flowIndex = 0;
            //    foreach (Card card in playerInventory)
            //    {
            //        Console.ForegroundColor = ConsoleColor.White;

            //        ChangeCardBackgroundColor(card);

            //        Console.Write("| " + card.Name + " |");

            //        NormalizeColor();
            //    }
            //}

            //public string PlayerInventory(Player player)
            //{
            //    Console.ForegroundColor = ConsoleColor.White;
            //    string playerInventory = "";

            //    //PRINTING REAL ESTATES
            //    foreach (RealEstate realEstate in player.realEstateList)
            //    {
            //        switch (realEstate.Rarity)
            //        {
            //            case "brown":
            //                Console.BackgroundColor = ConsoleColor.DarkMagenta;
            //                break;
            //            case "blue":
            //                Console.BackgroundColor = ConsoleColor.Blue;
            //                break;
            //            case "magenta":
            //                Console.BackgroundColor = ConsoleColor.Magenta;
            //                break;
            //            case "darkyellow":
            //                Console.BackgroundColor = ConsoleColor.DarkYellow;
            //                break;
            //            case "red":
            //                Console.BackgroundColor = ConsoleColor.Red;
            //                break;
            //            case "yellow":
            //                Console.BackgroundColor = ConsoleColor.Yellow;
            //                break;
            //            case "green":
            //                Console.BackgroundColor = ConsoleColor.Green;
            //                break;
            //            case "darkBlue":
            //                Console.BackgroundColor = ConsoleColor.DarkBlue;
            //                break;
            //        }
            //        playerInventory += "|" + realEstate.Name + "| ";
            //        Console.ForegroundColor = ConsoleColor.White;
            //    }
            //    return playerInventory;



            //Color changers

            //public void ChangeCardForegroundColor(Card card)
            //{
            //    if (card.Name.ToLower().Contains("gray"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Gray;
            //    }
            //    else if (card.Name.ToLower().Contains("blue"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Blue;
            //    }
            //    else if (card.Name.ToLower().Contains("magenta"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Magenta;
            //    }
            //    else if (card.Name.ToLower().Contains("dark yellow"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkYellow;
            //    }
            //    else if (card.Name.ToLower().Contains("red"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Red;
            //    }
            //    else if (card.Name.ToLower().Contains("yellow"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Yellow;
            //    }
            //    else if (card.Name.ToLower().Contains("green"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.Green;
            //    }
            //    else if (card.Name.ToLower().Contains("dark blue"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkBlue;
            //    }
            //    else if (card.Name.ToLower().Contains("road"))
            //    {
            //        Console.ForegroundColor = ConsoleColor.DarkGray;
            //    }
            //}
            //public void ChangeCardBackgroundColor(Card card)
            //{
            //    if (card.Name.ToLower().Contains("gray"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.Gray;
            //    }
            //    else if (card.Name.ToLower().Contains("blue"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.Blue;
            //    }
            //    else if (card.Name.ToLower().Contains("magenta"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.Magenta;
            //    }
            //    else if (card.Name.ToLower().Contains("dark yellow"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkYellow;
            //    }
            //    else if (card.Name.ToLower().Contains("red"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.Red;
            //    }
            //    else if (card.Name.ToLower().Contains("yellow"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.Yellow;
            //    }
            //    else if (card.Name.ToLower().Contains("green"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.Green;
            //    }
            //    else if (card.Name.ToLower().Contains("dark blue"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkBlue;
            //    }
            //    else if (card.Name.ToLower().Contains("road"))
            //    {
            //        Console.BackgroundColor = ConsoleColor.DarkGray;
            //    }
            //}
        }
    }
}
