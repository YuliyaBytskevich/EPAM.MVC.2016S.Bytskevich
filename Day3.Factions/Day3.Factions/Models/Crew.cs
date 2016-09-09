using System.Collections.Generic;

namespace Day3.Factions.Models
{
    public class Crew
    {
        public List<Person> people;
        private static Crew instance;

        public static Crew GetInstance()
        {
            return instance ?? (instance = new Crew());
        }

        private Crew()
        {
            people = new List<Person>();
            people.Add(new Person()
            {
                Id = 1,
                Name = "Jerry",
                LastName = "Mouse",
                Side = Side.Dark
            });
            people.Add(new Person()
            {
                Id = 2,
                Name = "Tom",
                LastName = "Cat",
                Side = Side.Light
            });
        }
    }
}