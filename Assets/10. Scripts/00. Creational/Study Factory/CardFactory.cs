using UnityEngine;

namespace Study.OOP.Factory
{
    public partial class Card
    {
        public abstract class Factory
        {
            protected abstract string[] Names { get; set; }
            protected abstract int MinValue { get; set; }
            protected abstract int MaxValue { get; set; }

            public bool InRange(int value) => (MinValue <= value && value < MaxValue);

            public Card CreateBaseCard()
            {
                string cardName = Names[Random.Range(0, Names.Length)];
                int value = Random.Range(MinValue, MaxValue);
                return null;
            }

            public abstract Card CreateCard()
            {
                
            }
        }
    }

    public class CardFactory
    {
        
    }
}