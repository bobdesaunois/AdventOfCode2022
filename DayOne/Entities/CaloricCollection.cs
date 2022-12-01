namespace DayOne.Entities
{
    public class CaloricCollection
    {

        private List<Calories> Calories { get; set; } = new ();

        public int GetTotalAmount ()
            => Calories.Sum (c => c.Amount);

        public void Add (Calories calories)
        {

            Calories.Add (calories);

        }

    }
}
