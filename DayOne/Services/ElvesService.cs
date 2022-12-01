using DayOne.Entities;

namespace DayOne.Services
{
    public class ElvesService
    {

        public List<Elf> BuildElvesWithCaloricCollections (List<CaloricCollection> caloricCollections)
        {

            List<Elf> elves = new ();
            foreach (CaloricCollection collection in caloricCollections)
                elves.Add (new Elf { Calories = collection });

            return elves;

        }

        public Elf FindHighestContributor (List<Elf> elves)
            => elves.Aggregate ((elf1, elf2) => elf1.Calories.GetTotalAmount () > elf2.Calories.GetTotalAmount () ? elf1 : elf2);

        public int GetContribution (Elf elf)
            => elf.Calories.GetTotalAmount ();

        public List<Elf> FindThreeHighestContributors (List<Elf> elves)
            => elves.OrderByDescending (e => e.Calories.GetTotalAmount ())
                .Take (3)
                .ToList();
    }
}
