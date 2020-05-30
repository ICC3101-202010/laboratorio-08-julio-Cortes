using System;

namespace Lab8
{
    public class CreateRecreationalArgs:EventArgs
    {
        public string ownername { get; set; }
        public int id { get; set; }
        public string schedule { get; set; }
    }
}