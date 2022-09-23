using System.Collections;
using Vistitor;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        var dogs = new List<Dog>();
        dogs.Add(new Dog { Name = "Pudge", Breed = Breed.Beagle, BirthDate = DateTime.Parse("1984-01-01"), DatePassed = DateTime.Parse("1990-12-12") });
        dogs.Add(new Dog { Name = "Cheech", Breed = Breed.Chihuahua, BirthDate = DateTime.Parse("1990-09-01"), DatePassed = DateTime.Parse("2001-03-12") });
        dogs.Add(new Dog { Name = "Chong", Breed = Breed.Pug, BirthDate = DateTime.Parse("1992-04-15"), DatePassed = DateTime.Parse("2004-06-01") });

        var visitor = new CalculateDogAge();
        foreach (var dog in dogs)
        {
            dog.Accept(visitor);
        }
    }

}