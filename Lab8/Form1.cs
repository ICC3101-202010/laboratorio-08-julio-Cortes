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
    public partial class Form1 : Form
    {
        public delegate bool CreateStoreEventHandler(object source, CreateStoreArgs args);
        public event CreateStoreEventHandler FinalAddStoreClick;
        public delegate bool CreateRestaurantEventHandler(object source, CreateRestaurantArgs args);
        public event CreateRestaurantEventHandler FinalAddRestaurantClick;
        public delegate bool CreateCinemaEventHandler(object source, CreateCinemaArgs args);
        public event CreateCinemaEventHandler FinalAddCinemaClick;
        public delegate bool CreateRecreatinalEventHander(object source, CreateRecreationalArgs args);
        public event CreateRecreatinalEventHander FinalAddRecreationalClick;




        public Form1()
        {
            InitializeComponent();
            StorePanel.Dock = System.Windows.Forms.DockStyle.Fill;
            CinemaPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            RestaurantPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            RecreationalPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            BasePanel.Dock = System.Windows.Forms.DockStyle.Fill;
        }

        private void AddStoreButton_Click(object sender, EventArgs e)
        {
            StorePanel.Visible = true;
            CinemaPanel.Visible = false;
            RestaurantPanel.Visible = false;
            RecreationalPanel.Visible = false;
        }

        private void BackButtomAdding_Click(object sender, EventArgs e)
        {
            AddPanel.Visible = false;
            BasePanel.Visible = true;
        }

        private void AddCinemaButton_Click(object sender, EventArgs e)
        {
            StorePanel.Visible = false;
            CinemaPanel.Visible = true;
            RestaurantPanel.Visible = false;
            RecreationalPanel.Visible = false;

        }

        private void AddRestaurantButton_Click(object sender, EventArgs e)
        {
            StorePanel.Visible = false;
            CinemaPanel.Visible = false;
            RestaurantPanel.Visible = true;
            RecreationalPanel.Visible = false;
        }

        private void AddRecreationalButton_Click(object sender, EventArgs e)
        {
            StorePanel.Visible = false;
            CinemaPanel.Visible = false;
            RestaurantPanel.Visible = false;
            RecreationalPanel.Visible = true;
        }

        private void AddLocal_ButtonClick(object sender, EventArgs e)
        {
            AddPanel.Visible = true;
            BasePanel.Visible = false;
        }

        private void FinalAddStore_Click(object sender, EventArgs e)
        {
            string ownername = StoreNameTextBox.Text;
            int id;
            string schedule = StoreSheduleLabel.Text;
            string category = StoreCategoryLabel.Text;
            bool succes = int.TryParse(StoreIDLabel.Text, out id);
            if (succes)
            {
                OnFinalAddStore(ownername, id, schedule, category);
            }
            else
            {
                StoreIDLabel.Text = "Invalid Format, please put a number in this box";
            }
        }

        private void OnFinalAddStore(string ownername,int id, string schedule, string category)
        {
            if (FinalAddStoreClick!=null)
            {
                bool result=FinalAddStoreClick(this, new CreateStoreArgs() { ownername = ownername, id = id, schedule = schedule, category = category });
                if (result)
                {
                    StorePanel.Visible = false;
                    StoreNameTextBox.Text = "";
                    StoreSheduleLabel.Text = "";
                    StoreCategoryLabel.Text = "";
                    StoreIDLabel.Text = Text;
                }
                else
                {
                    //Anadir id usado
                }
            }
        }

        private void FinalAddRestaurant_Click(object sender, EventArgs e)
        {
            string name = RestaurantNameTextBox.Text;
            int id;
            string schedule = RestaurantScheduleTextBox.Text;
            bool privatet;
            bool succes = int.TryParse(RestaurantIDTextBox.Text, out id);
            bool succes2 = bool.TryParse(RestaurantPrivateTextBox.Text, out privatet);
            if (succes&&succes2)
            {
                OnFinalAddRestaurant(name, id, schedule, privatet);
            }
            else if(succes)
            {
                RestaurantIDTextBox.Text = "Invalid Format, please put a number in this box";
            }
            else
            {
                RestaurantPrivateTextBox.Text = "Invalid Format";
            }
        }
        private void OnFinalAddRestaurant(string ownername, int id, string schedule, bool privatet)
        {
            if (FinalAddRestaurantClick!= null)
            {
                bool result = FinalAddRestaurantClick(this, new CreateRestaurantArgs() { ownername = ownername, id = id, schedule = schedule, privatet = privatet });
                if (result)
                {
                    RestaurantPanel.Visible = false;
                    RestaurantIDTextBox.Text = "";
                    RestaurantNameTextBox.Text = "";
                    RestaurantPrivateTextBox.Text = "";
                    RestaurantScheduleTextBox.Text = "";
                }
                else
                {
                    //Anadir id usado
                }
            }
        }

        private void FinalAddCinema_Click(object sender, EventArgs e)
        {
            string name = CinemaNameTextBox.Text;
            int id;
            string schedule = CinemaScheduleTextBox.Text;
            int nrooms;
            bool succes = int.TryParse(CinemaIDTextBox.Text, out id);
            bool succes2 = int.TryParse(CinemaNofRoomsLabel.Text, out nrooms);
            if (succes && succes2)
            {
                OnFinalAddCinema(name, id, schedule, nrooms);
            }
            else if (succes)
            {
                CinemaIDTextBox.Text = "Invalid Format, please put a number in this box";
            }
            else
            {
                CinemaNofRoomsLabel.Text = "Invalid Format, please put a number in this box";
            }
        }

        private void OnFinalAddCinema(string name, int id, string schedule, int nrooms)
        {
            if (FinalAddRestaurantClick != null)
            {
                bool result = FinalAddCinemaClick(this, new CreateCinemaArgs() { ownername = name, id = id, schedule = schedule, nrooms = nrooms });
                if (result)
                {
                    CinemaPanel.Visible = false;
                    CinemaIDTextBox.Text = "";
                    CinemaNameTextBox.Text = "";
                    CinemaScheduleTextBox.Text = "";
                    CinemaNofRoomsLabel.Text = "";
                }
                else
                {
                    //Anadir id usado
                }
            }
        }

        private void FinalAddRecreational_Click(object sender, EventArgs e)
        {
            string name = RecreationalNameTextBox.Text;
            int id;
            string schedule = RecreationalScheduleTextBox.Text;
            bool succes = int.TryParse(RecreationalIDTextBox.Text, out id);
            if (succes)
            {
                OnFinalAddRecreational(name, id, schedule);
            }
            else 
            {
                CinemaIDTextBox.Text = "Invalid Format, please put a number in this box";
            }

        }

        private void OnFinalAddRecreational(string name, int id, string schedule)
        {
            if (FinalAddRecreationalClick != null)
            {
                bool result = FinalAddRecreationalClick(this, new CreateRecreationalArgs() { ownername = name, id = id, schedule = schedule });
                if (result)
                {
                    RecreationalPanel.Visible = false;
                    RecreationalNameTextBox.Text = "";
                    RecreationalScheduleTextBox.Text = "";
                    RecreationalIDTextBox.Text = "";
                }
                else
                {
                    //Anadir id usado
                }
            }
        }
    }
}
