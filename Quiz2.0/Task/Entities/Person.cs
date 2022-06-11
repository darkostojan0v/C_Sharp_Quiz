using System;
using System.Collections.Generic;
using System.Text;
using Task.Enums;

namespace Task.Entities
{
    public class Person : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }
        public List<Role> Roles { get; set; }

        public Person(string firstName, string lastName, int age, List<Role> roles)
        {
            FirstName = firstName;
            LastName = lastName;
            Age = age;
            Roles = roles;
        }

        public override void GetInfo()
        {
            foreach (Role role in Roles)
            {
                Console.WriteLine(role);
            }

        }
        
    }
}
