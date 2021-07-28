using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LunchBuddies
{
    class Restaurant
    {
        public string Name;
        private List<string> RestaurantList { get; set; }

        public Restaurant()
        {
            string[] restaurants = new string[] { "Rosie Food & Wine", "Lou Nashville", "400 Degrees", "East Side Banh Mi",
                                    "Big Al's Deli", "Folk", "Redheaded Stranger", "Peninsula", "Dino's Bar", "Ed's Fish & Pizza House"};
            RestaurantList = new List<string>();
            Random random = new Random();
            int index = random.Next(0, restaurants.Length - 1);

            foreach(var restaurant in restaurants)
            {
                RestaurantList.Add(restaurant);
            }
            Name = RestaurantList[index];
        }

        public void RandomRestaurant()
        {
            Random random = new Random();
            int index = random.Next(0, RestaurantList.Count - 1);
            Name = RestaurantList[index];
        }
    }
}
