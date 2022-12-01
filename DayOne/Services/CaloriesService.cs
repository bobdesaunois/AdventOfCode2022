using DayOne.Entities;
using DayOne.Repositories;

namespace DayOne.Services
{
    public class CaloriesService
    {

        private CaloriesRepository Calories = new ();

        public async Task<List<CaloricCollection>> GetCaloricCollectionsAsync ()
            => await Calories.GetCaloriesFromInputFile ();

    }
}
