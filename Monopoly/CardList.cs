using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class CardList
    {
        public List<Card> cards = new List<Card>();

        RealEstate realEstate1 = new RealEstate("Bank", "Gray House", 600,20, 1);
        RealEstate realEstate2 = new RealEstate("Bank", "Gray House2", 600,40, 3);

        RealEstate realEstate3 = new RealEstate("Bank", "Blue House", 1000, 6, 6);
        RealEstate realEstate4 = new RealEstate("Bank", "Blue House2", 1000, 6, 8);
        RealEstate realEstate5 = new RealEstate("Bank", "Blue House3", 1200, 80, 9);

        RealEstate realEstate6 = new RealEstate("Bank", "Magenta House", 1400, 100,11 );
        RealEstate realEstate7 = new RealEstate("Bank", "Magenta House2", 1400, 100, 13);
        RealEstate realEstate8 = new RealEstate("Bank", "Magenta House2", 1600, 120, 14);

        RealEstate realEstate9 = new RealEstate("Bank", "Dark Yellow House", 1800, 140, 16);
        RealEstate realEstate10 = new RealEstate("Bank", "Dark Yellow House2", 1800, 140, 18);
        RealEstate realEstate11 = new RealEstate("Bank", "Dark Yellow House3", 2000, 16, 19);

        RealEstate realEstate12 = new RealEstate("Bank", "Red House", 2200, 180, 21);
        RealEstate realEstate13 = new RealEstate("Bank", "Red House2", 2200, 180, 23);  
        RealEstate realEstate14 = new RealEstate("Bank", "Red House3", 2400, 200, 24);

        RealEstate realEstate15 = new RealEstate("Bank", "Yellow House", 2600, 220, 26);
        RealEstate realEstate16 = new RealEstate("Bank", "Yellow House2", 2600, 220, 27);
        RealEstate realEstate17 = new RealEstate("Bank", "Yellow House3", 2800, 240, 29);

        RealEstate realEstate18 = new RealEstate("Bank", "Green House", 3000, 260, 31);
        RealEstate realEstate19 = new RealEstate("Bank", "Green House2", 3000, 260, 32);
        RealEstate realEstate20 = new RealEstate("Bank", "Green House3", 3200, 280, 34);

        RealEstate realEstate21 = new RealEstate("Bank", "Dark Blue House", 3500, 350, 37);
        RealEstate realEstate22 = new RealEstate("Bank", "Dark Blue House2", 4000, 500, 39);
         
        Card railRoad = new Card("Bank", "Rail Road", 200, 200, 5);
        Card railRoad2 = new Card("Bank", "Rail Road 2", 200, 200, 15);
        Card railRoad3 = new Card("Bank", "Rail Road 3", 200, 200, 25);
        Card railRoad4 = new Card("Bank", "Rail Road 4", 200, 200, 35);

        public CardList()
        {
            cards.Add(realEstate1);
            cards.Add(realEstate2);
            cards.Add(realEstate3);
            cards.Add(realEstate4);
            cards.Add(realEstate5);
            cards.Add(realEstate6);
            cards.Add(realEstate7);
            cards.Add(realEstate8);
            cards.Add(realEstate9);
            cards.Add(realEstate10);
            cards.Add(realEstate11);
            cards.Add(realEstate12);
            cards.Add(realEstate13);
            cards.Add(realEstate14);
            cards.Add(realEstate15);
            cards.Add(realEstate16);
            cards.Add(realEstate17);
            cards.Add(realEstate18);
            cards.Add(realEstate19);
            cards.Add(realEstate20);
            cards.Add(realEstate21);
            cards.Add(realEstate22);
            cards.Add(railRoad);
            cards.Add(railRoad2);
            cards.Add(railRoad3);
            cards.Add(railRoad4);
        }
    }
}
