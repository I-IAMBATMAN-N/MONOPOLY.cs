using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Monopoly
{
    internal class Card
    {
        public string Owner { get; set; }
        public string Name { get; set; }
        public int Price { get; set; }
        public int Rent { get; private set; }
        public int Position { get; set; }

        public Card()
        {
            Owner = "Default";  
            Name = "Default";
            Price = 0;
            Rent = 0;
        }
        public Card(string Owner, string Name, int Price, int Rent, int Position)
        {
            this.Owner = Owner;
            this.Name = Name;
            this.Price = Price;
            this.Rent = Rent;
            this.Position = Position;
        }
        public virtual void AdjustRent(int firstArgument)
        {
            Console.WriteLine("Rent before adjustment:\n" ,  Rent);
            Rent += Rent/2 * firstArgument;
            Console.WriteLine("Adjustmed rent", Rent);
        }
    }
}
