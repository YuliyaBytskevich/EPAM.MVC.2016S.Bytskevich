using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day3.HW.Fractions.Models
{
    public class Crew
    {
        public List<Person> people; 

        public Crew()
        {
            people = new List<Person>();
            people.Add(new Person()
            {
                Name = "Jerry",
                LastName = "Mouse",
                Side = Side.Dark
            });
            people.Add(new Person()
            {
                Name = "Tom",
                LastName = "Cat",
                Side = Side.Light
            });
        }
    }
}