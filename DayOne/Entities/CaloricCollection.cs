using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayOne.Entities
{
    public class CaloricCollection
    {

        public List<Calories> Calories { get; set; } = new ();

        public int GetTotalAmount ()
            => Calories.Sum (c => c.Amount);

    }
}
