using System;

namespace Lab8
{
    public class CreateStoreArgs:EventArgs
    {
        public string ownername { get; set; }
        public int id { get; set; }
        public string schedule { get; set; }
        public string category { get; set; }
    }
}