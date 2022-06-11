using System;
using System.Collections.Generic;
using Task.Entities;
using Task.Enums;

namespace Task
{
    public class Program
    {
        static void Main(string[] args)
        {
            List<Person> castOfFastAndFurious = new List<Person>()
            {
                new Person("Vin", "Diesel", 42, new List<Role> {Role.Actor, Role.Producer}),
                new Person("Paul", "Walker", 36, new List<Role> {Role.Actor}),
                new Person("Michelle", "Rodriguez", 31, new List<Role> {Role.Actor}),
                new Person("Jordana", "Brewster", 29, new List<Role> {Role.Actor}),
                new Person("Justin", "Lin", 38, new List<Role> {Role.Director}),
                new Person("Neal H.", "Moritz", 50, new List<Role> {Role.Producer}),
                new Person("Michael", "Fottrell", 41, new List<Role> {Role.Producer}),
            };

            List<Person> castOfTheItalianJob = new List<Person>()
            {
                new Person("Mark", "Wahlberg", 32, new List<Role> {Role.Actor}),
                new Person("Edward", "Norton", 34, new List<Role> {Role.Actor}),
                new Person("Charlize", "Theron", 28, new List<Role> {Role.Actor}),
                new Person("Jason", "Statham", 36, new List<Role> {Role.Actor}),
                new Person("Aleksander", "Krupa", 56, new List<Role> {Role.Actor}),
                new Person("Donald", "De Line", 46, new List<Role> {Role.Producer}),
                new Person("F. Gary", "Gray", 34, new List<Role> {Role.Director}),
            };

            List<Person> castOfDumbAndDumber = new List<Person>()
            {
                new Person("Jim", "Carrey", 32, new List<Role> {Role.Actor}),
                new Person("Jeff", "Daniels", 39, new List<Role> {Role.Actor}),
                new Person("Mike", "Star", 44, new List<Role> {Role.Actor}),
                new Person("Lauren", "Holly", 31, new List<Role> {Role.Actor}),
                new Person("Charles", "Claverie", 45, new List<Role> {Role.Actor}),
                new Person("Charles", "Wessler", 39, new List<Role> {Role.Producer}),
                new Person("Brad", "Krevoy", 38, new List<Role> {Role.Producer}),
                new Person("Peter J.", "Farrelly", 38, new List<Role> {Role.Director}),
            };

            List<Person> castOfTheConjuring = new List<Person>()
            {
                new Person("Patrick", "Wilson", 40, new List<Role> {Role.Actor}),
                new Person("Vera", "Farmiga", 40, new List<Role> {Role.Actor}),
                new Person("Ron", "Livingston", 46, new List<Role> {Role.Actor}),
                new Person("Lili", "Taylor", 46, new List<Role> {Role.Actor}),
                new Person("Peter", "Safran", 48, new List<Role> {Role.Producer}),
                new Person("James", "Wan", 36, new List<Role> {Role.Director}),
            };

            List<Person> castOfTheSixthSense = new List<Person>()
            {
                new Person("Bruce", "Willis", 44, new List<Role> {Role.Actor}),
                new Person("Toni", "Collett", 27, new List<Role> {Role.Actor}),
                new Person("Olivia", "Williams", 31, new List<Role> {Role.Actor}),
                new Person("Haley J.", "Osment", 11, new List<Role> {Role.Actor}),
                new Person("Frank", "Marshall", 53, new List<Role> {Role.Producer}),
                new Person("Kathleen", "Kennedy", 46, new List<Role> {Role.Producer}),
                new Person("Barry", "Mendel", 36, new List<Role> {Role.Producer}),
                new Person("Manoy", "Shyamalan", 29, new List<Role> {Role.Director}),
            };

            Movie FastAndFurious = new Movie("Fast And Furious", 2009, new List<Genre> { Genre.Action },
                new List<Person> {castOfFastAndFurious[0], castOfFastAndFurious[1], castOfFastAndFurious[2], castOfFastAndFurious[3],
                castOfFastAndFurious[4], castOfFastAndFurious[5], castOfFastAndFurious[6] });
            Movie TheItalianJob = new Movie("The Italian Job", 2003, new List<Genre> { Genre.Adventure },
                new List<Person> {castOfTheItalianJob[0], castOfTheItalianJob[1], castOfTheItalianJob[2], castOfTheItalianJob[3],
                castOfTheItalianJob[4], castOfTheItalianJob[5], castOfTheItalianJob[6] });
            Movie DumbAndDumber = new Movie("Dumb & Dumber", 1994, new List<Genre> { Genre.Comedy }, 
                new List<Person> {castOfDumbAndDumber[0], castOfDumbAndDumber[1], castOfDumbAndDumber[2], castOfDumbAndDumber[3],
                castOfDumbAndDumber[4], castOfDumbAndDumber[5], castOfDumbAndDumber[6], castOfDumbAndDumber[7] });
            Movie TheConjuring = new Movie("The Conjuring", 2013, new List<Genre> { Genre.Horror },
                new List<Person> {castOfTheConjuring[0], castOfTheConjuring[1], castOfTheConjuring[2], castOfTheConjuring[3],
                castOfTheConjuring[4], castOfTheConjuring[5] });
            Movie TheSixthSense = new Movie("The Sixth Sense", 1999, new List<Genre> { Genre.Thriller },
                new List<Person> {castOfTheSixthSense[0], castOfTheSixthSense[1], castOfTheSixthSense[2], castOfTheSixthSense[3],
                castOfTheSixthSense[4], castOfTheSixthSense[5], castOfTheSixthSense[6], castOfTheSixthSense[7] });

            FastAndFurious.GetInfo();
            TheItalianJob.GetInfo();
            DumbAndDumber.GetInfo();
            TheConjuring.GetInfo();
            TheSixthSense.GetInfo();
        }
    }
}
