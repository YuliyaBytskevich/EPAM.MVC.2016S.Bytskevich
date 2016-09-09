using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Day2.Controllers.Models
{
    public class User
    {
        public int Id { get; }
        public string Name { get; set; }
        public string LastName { get; set; }

        public User() {}

        public User(int id, string name, string lastName)
        {
            Id = id;
            Name = name;
            LastName = lastName;
        }
    }
}