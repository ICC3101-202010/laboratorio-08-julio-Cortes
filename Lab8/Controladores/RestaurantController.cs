using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Controladores
{
    public class RestaurantController
    {
        private List<Restaurant> restaurants = new List<Restaurant>();
        Form1 form1;
        public RestaurantController(Form1 form1)
        {
            this.form1 = form1;
            this.form1.FinalAddRestaurantClick += OnFInalAddRestaurantClick;
            this.form1.LoadRestaurant += OnLoadRestaurant;
        }

        private List<Restaurant> OnLoadRestaurant(object source, LocalInfoArgs args)
        {
            return restaurants;
        }

        public List<Restaurant> Restaurants { get => restaurants; set => restaurants = value; }

        private bool OnFInalAddRestaurantClick(object source, CreateRestaurantArgs args)
        {
            Restaurant restaurant = null;
            restaurant = Restaurants.Where(u => u.Id == args.id).FirstOrDefault();
            if (restaurant is null)
            {
                restaurants.Add(new Restaurant(args.ownername, args.id, args.schedule, args.privatet));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
