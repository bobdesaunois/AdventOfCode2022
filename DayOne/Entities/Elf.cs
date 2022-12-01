﻿namespace DayOne.Entities
{
    public class Elf
    {

        public Guid Id { get; private set; } = Guid.NewGuid ();
        public CaloricCollection Calories { get; set; } = new ();

    }
}
