using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Lab8
{
    public partial class Form2 : Form
    {
        private List<Store> stores = new List<Store>();
        private List<Restaurant> restaurants = new List<Restaurant>();
        private List<Cinema> cinemas = new List<Cinema>();
        private List<Recreational> recreationals = new List<Recreational>();
        public Form2(List<Store> stores, List<Restaurant> restaurants, List<Cinema> cinemas, List<Recreational> recreationals)
        {
            InitializeComponent();
            this.stores = stores;
            this.restaurants = restaurants;
            this.cinemas = cinemas;
            this.recreationals = recreationals;
        }

        private void Form2_Load(object sender, EventArgs e)
        {
            foreach (Store store in stores)
            {
                StoresData.Rows.Add(store.Owner,store.Id,store.Schedule,store.Category);
            }
            foreach (Restaurant restaurant in restaurants)
            {
                RestaurantsData.Rows.Add(restaurant.Owner, restaurant.Id, restaurant.Schedule, restaurant.Privatetables);
            }
            foreach (Cinema cinema in cinemas)
            {
                CinemaData.Rows.Add(cinema.Owner, cinema.Id, cinema.Schedule, cinema.TheatherRooms1);
            }
            foreach (Recreational recreational in recreationals)
            {
                RecreationalData.Rows.Add(recreational.Owner, recreational.Id, recreational.Schedule);
            }

        }

        private void Selector_SelectedIndexChanged(object sender, EventArgs e)
        {
            int caser=Selector.SelectedIndex;
            StoresData.Visible = false;
            RestaurantsData.Visible = false;
            CinemaData.Visible = false;
            RecreationalData.Visible = false;
            switch (caser)
            {
                case 0:
                    StoresData.Visible = true;
                    break;
                case 1:
                    RestaurantsData.Visible = true;
                    break;
                case 3:
                    RecreationalData.Visible = true;
                    break;
                case 2:
                    CinemaData.Visible = true;
                    break;
                default:
                    break;
            }
        }
    }
}
