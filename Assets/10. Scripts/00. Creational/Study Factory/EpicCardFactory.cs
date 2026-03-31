namespace Study.OOP.Factory
{
    public partial class EpicCard
    {
        public class EpicCardFactory : Factory
        {
            protected override string[] Names { get; set; }
            protected override int MinValue { get; set; }
            protected override int MaxValue { get; set; }
            public override Card CreateCard()
            {
                throw new System.NotImplementedException();
            }
        }
    }
}