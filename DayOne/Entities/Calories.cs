namespace DayOne.Entities
{
    public class Calories
    {

        public Guid ID { get; private set; } = Guid.NewGuid();
        public int Amount { get; set; }

    }
}
