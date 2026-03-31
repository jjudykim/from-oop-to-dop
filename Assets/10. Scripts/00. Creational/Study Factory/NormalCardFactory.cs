using UnityEngine;

namespace Study.OOP.Factory
{
    public partial class NormalCard
    {
        public class NormalCardFactory : Card.Factory
        {
            protected override string[] Names { get; set; } = new string[] {};
            protected override int MinValue { get; set; }
            protected override int MaxValue { get; set; }
        
            public override Card CreateCard()
            {
                string randName = Names[Random.Range(0, Names.Length)];
                Card card = new NormalCard(randName, Random.Range(MinValue, MaxValue));
                return card;
            }
        }
    }

    
}