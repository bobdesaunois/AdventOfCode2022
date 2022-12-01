using DayOne.Entities;
using DayOne.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne
{
    public class ElfCalorieCounter
    {

        private CaloriesService Calories = new ();
        private ElvesService Elves = new ();

        public async Task RunAsync ()
        {

            List<Elf> elves = Elves.BuildElvesWithCaloricCollections (
                await Calories.GetCaloricCollectionsAsync ()
                );

            Elf highestContributor = Elves.FindHighestContributor (elves);

            Console.WriteLine ($"The elf with the highest contributed calories is elf {highestContributor.Id}");
            Console.WriteLine ($"This Elf contributed a total of {Elves.GetContribution (highestContributor)}");

            List<Elf> threeHighestContributors = Elves.FindThreeHighestContributors (elves);

            Console.WriteLine ("The top three highest contributors are the following elves:");
            foreach (Elf elf in threeHighestContributors)
                Console.WriteLine ($"{elf.Id} with a contribution of {elf.Calories.GetTotalAmount()}");

            Console.WriteLine ($"Together they contributed a total of {threeHighestContributors.Sum (e => e.Calories.GetTotalAmount ())} calories");

        }

    }
}
