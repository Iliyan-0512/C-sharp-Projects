using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cards
{
    public class Card
    {
        private string face;
        private string suit;

        private static readonly List<string> FACES= new List<string> { "2", "3", "4", "5", "6", "7", "8", "9", "10", "J", "Q", "K", "A" };
        private static readonly List<string> SUITS = new List<string> { "S", "H", "D", "C" };
        public Card(string face, string suit)
        {
            this.Face = face;
            this.Suit = suit;
        }
        public string Face
        {
            get { return this.face; }
            set
            {
                if (!FACES.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                else
                {
                    face = value;
                }
            }
        }
        public string Suit
        {
            get { return this.suit; }
            set
            {
                if (!SUITS.Contains(value))
                {
                    throw new ArgumentException("Invalid card!");
                }
                else
                {
                    suit = value;
                }
            }
        }
        public override string ToString()
        {
            if (this.Face != null&& this.Suit!=null)
            {
                StringBuilder sb = new StringBuilder();
                sb.Append(this.Face);
                if (this.Suit=="H")
                {
                    byte[] bytes = Encoding.Default.GetBytes("\u2660");
                    string myString = Encoding.UTF8.GetString(bytes);
                    sb.Append(myString);
                }
                else if (this.Suit == "H")
                {
                    byte[] bytes = Encoding.Default.GetBytes("\u2665");
                    string myString = Encoding.UTF8.GetString(bytes);
                    sb.Append(myString);
                }
                else if (this.Suit == "D")
                {
                    byte[] bytes = Encoding.Default.GetBytes("\u2666");
                    string myString = Encoding.UTF8.GetString(bytes);
                    sb.Append(myString);
                }
                else if (this.Suit == "C")
                {
                    byte[] bytes = Encoding.Default.GetBytes("\u2663");
                    string myString = Encoding.UTF8.GetString(bytes);
                    sb.Append(myString);
                }
                return $"[{sb.ToString()}]";
            }
            return null;
        }
        

    }
}
