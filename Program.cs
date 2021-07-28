using System;
using System.Collections.Generic;
using LunchBuddies;


namespace LunchBuddies
{
    class Program
    {
        static void Main(string[] args)
        {
            Restaurant RestaurantChooser = new Restaurant();
            LunchBuddy fred = new LunchBuddy("Fred", "Carpenter");
            LunchBuddy joe = new LunchBuddy("Joe ", "Janitor");
            LunchBuddy barney = new LunchBuddy("Barney", "Flinstone");
            LunchBuddy george = new LunchBuddy("George", "FlintMaker");
            LunchBuddy mike = new LunchBuddy("Mike", "Mason");

            List<LunchBuddy> companions = new List<LunchBuddy>();

            companions.Add(joe);
            companions.Add(barney);
            companions.Add(george);
            companions.Add(mike);

            Console.WriteLine("Welcome to Lunch Buddies");

            fred.eat();
            fred.eat("Pasta");
            fred.SwitchRestaurants();
            fred.eat(companions);
            fred.eat("Pizza", companions);
        }
    }
}
