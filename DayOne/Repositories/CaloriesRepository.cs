using DayOne.Entities;

namespace DayOne.Repositories
{
    public class CaloriesRepository
    {

        public async Task<List<CaloricCollection>> GetCaloriesFromInputFile ()
        {

            List<CaloricCollection> collections     = new ();
            CaloricCollection       currentScope    = new ();
            using StreamReader reader = File.OpenText ("input.txt");
            while ( ! reader.EndOfStream)
            {

                string? line = await reader.ReadLineAsync ();

                if (line == null) continue;

                if (line.Length > 0)
                {

                    currentScope.Add (
                        new Calories
                        {
                            Amount = Convert.ToInt32 (line)
                        });
                
                } else
                {

                    collections.Add (currentScope);
                    currentScope = new CaloricCollection ();

                }

            }

            return collections;

        }

    }
}
