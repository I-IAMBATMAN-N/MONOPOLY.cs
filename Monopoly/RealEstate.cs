using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class RealEstate: Card
    {
        Player player = new Player();

        public string Rarity { get; set; }

        public int Houses { get; set; } = 0;

        string[] rarity = { "brown","blue","magenta","darkyellow","red","yellow","green", "darkBlue" };

        public RealEstate(string Owner, string Name, int Price, int Rent, int Position): base(Owner, Name, Price, Rent, Position)
        {

        }
        public RealEstate()
        {
            Rarity = "DR";
            Houses = 0;
        }
        void SpareFUnctions()
        {
            //void BuyHouses(Player player)
            //{
            //    Console.WriteLine("How many houses do you want to buy?");
            //    int count = int.Parse(Console.ReadLine());

            //    int price = 0;
            //    while (price == 0)
            //    {
            //        for (int i = 0; i <= 8; i++)
            //        {
            //            int pricing = 150;
            //            if (GetRarityIndex() == i)
            //            {
            //                price = pricing;
            //            }
            //            pricing += 150 / 4;
            //        }
            //    }

            //    switch (count)
            //    {
            //        case 1:
            //            player.AdjustBalance(price);
            //            Console.WriteLine("You have bought {0} for {1} dollars", count, price);
            //            break;
            //        case 2:
            //            player.AdjustBalance(price * 2);
            //            Console.WriteLine("You have bought {0} for {1} dollars", count, price * 2);
            //            break;
            //        case 3:
            //            player.AdjustBalance(price * 3);
            //            Console.WriteLine("You have bought {0} for {1} dollars", count, price * 3);
            //            break;
            //        case 4:
            //            player.AdjustBalance(price * 4);
            //            Console.WriteLine("You have bought {0} for {1} dollars", count, price * 4);
            //            break;
            //    }

            //    Houses += count;

            //    //card.AdjustRent(count);

            //    int GetRarityIndex()
            //    {
            //        int rarityIndex = 0;
            //        for (int j = 0; j < rarity.Length; j++)
            //        {
            //            if (Rarity == rarity[j])
            //            {
            //                rarityIndex = j;
            //            }
            //        }
            //        return rarityIndex;
            //    }
            //}
        }
    }
}
