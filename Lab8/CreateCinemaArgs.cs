using System;

namespace Lab8
{
    public class CreateCinemaArgs:EventArgs
    {
        public string ownername { get; set; }
        public int id { get; set; }
        public string schedule { get; set; }
        public int nrooms { get; set; }
    }
}