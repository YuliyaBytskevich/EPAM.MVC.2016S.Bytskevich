using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using System.Web;

namespace Day2.Controllers.Models
{
    public class UserCollection
    {
        public List<User> Users { get; }
        private int idCounter;
        private static UserCollection instance;

        public static  UserCollection GetInstance()
        {
            return instance ?? (instance = new UserCollection());
        }

        private UserCollection()
        {
            Users = new List<User>();
            idCounter = 1;
            Add("Jerry", "Mouse");
            Add("Tom", "Cat");
            Add("Darth", "Vader");
        }

        public void Add(string name, string lastName)
        {
            Users.Add(new User(idCounter++, name, lastName));
        }

        public async void AddAsync(string name, string lastName)
        {
            await Task.Run(() =>
            {
                Add(name, lastName);
            });
        }

        public void Delete(int id)
        {
            Users.RemoveAll(x => x.Id == id);
        }

        public void Delete(string name, string lastName)
        {
            Users.RemoveAll(x => x.Name == name && x.LastName == lastName);
        }

        public void Edit(int id, string name, string lastName)
        {
            var toBeEdited = Users.First(x => x.Id == id);
            toBeEdited.Name = name;
            toBeEdited.LastName = lastName;
        }

        public override string ToString()
        {
            return Users.Aggregate("", (current, user) => current + ("user[" + user.Id + "] : " + user.Name + " " + user.LastName));
        }
    }
}