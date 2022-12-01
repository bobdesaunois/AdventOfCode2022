namespace DayOne.Entities
{
    public class Elf
    {

        public Guid Id { get; private set; } = Guid.NewGuid ();
        public CaloricCollection Calories;

        public Elf ()
        {

            Calories = new CaloricCollection ();

        }

    }
}
