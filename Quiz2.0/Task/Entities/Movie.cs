using System;
using System.Collections.Generic;
using System.Text;
using Task.Enums;

namespace Task.Entities
{
    public class Movie : BaseEntity
    {
        public string Title { get; set; }
        public int Year { get; set; }
        public List<Genre> Genres { get; set; }
        public List<Person> Person { get; set; }

        public Movie(string title, int year, List<Genre> genres, List<Person> person)
        {
            Title = title;
            Year = year;
            Genres = genres;
            Person = person;
        }

        public override void GetInfo()
        {
            foreach (Genre genre in Genres)
            {
                Console.WriteLine($"The movie '{Title}' has been released in {Year} year, characterized as {genre} film.");
            }

            Console.WriteLine("The crew behind this film is: ");

            foreach (Person person in Person)
            {
                Console.WriteLine($"- {person.FirstName} {person.LastName} at {person.Age} years of age.");
            }
            
        }

    }
}
