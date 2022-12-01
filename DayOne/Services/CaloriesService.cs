using DayOne.Entities;
using DayOne.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne.Services
{
    public class CaloriesService
    {

        private CaloriesRepository Calories = new ();

        public async Task<List<CaloricCollection>> GetCaloricCollectionsAsync ()
            => await Calories.GetCaloriesFromInputFile ();

    }
}
