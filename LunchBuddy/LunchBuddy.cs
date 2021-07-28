using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LunchBuddies;

namespace LunchBuddies {
    class LunchBuddy 
    {
        public string First { get; set; }
        public string Last { get; set; }

        private Restaurant RestaurantChoice;

        public LunchBuddy(string first, string last)
        {
            First = first;
            Last = last;
            RestaurantChoice = new Restaurant();
        }

        public string eat()
        {
            Console.WriteLine($"{First} {Last} is eating at {RestaurantChoice.Name}");
            return RestaurantChoice.Name;
        }

        public void eat(string food)
        {
            Console.WriteLine($"{First} {Last} is eating {food} at the office");
        }

        public void eat(List<LunchBuddy> companions)
        {
            Console.WriteLine($"{First} {Last} is at the {RestaurantChoice.Name} with his buddies:");
            ListBuddies(companions, 5);
        }

        public void eat(string food, List<LunchBuddy> companions)
        {
            RestaurantChoice.RandomRestaurant();
            Console.WriteLine($"{First} is at {RestaurantChoice.Name} eating {food} with his buddies:");
            ListBuddies(companions, 5);

        }

        public void SwitchRestaurants()
        {
            RestaurantChoice.RandomRestaurant();
        }

        private void ListBuddies(List<LunchBuddy> companions, int spaces)
        {
            foreach (var buddy in companions)
            {
                Console.Write(new string(' ', spaces));
                Console.WriteLine($"{buddy.First}");
            }
        }
                
    }
}
