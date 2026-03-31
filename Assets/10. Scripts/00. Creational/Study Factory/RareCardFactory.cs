using UnityEngine;

namespace Study.OOP.Factory
{
    public partial class RareCard
    {
        public partial class RareCardFactory : Card.Factory
        {
            protected override string[] Names { get; set; }
            protected override int MinValue { get; set; }
            protected override int MaxValue { get; set; }
            public override Card CreateCard()
            {
                string randName = Names[Random.Range]
            }
        }   
    }
}