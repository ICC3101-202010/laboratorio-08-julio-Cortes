using System;

namespace Lab8
{
    public class CreateRestaurantArgs:EventArgs
    {
        public string ownername { get; set; }
        public int id { get; set; }
        public string schedule { get; set; }
        public bool privatet { get; set; }
    }
}