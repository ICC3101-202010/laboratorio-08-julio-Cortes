using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Cinema : Local
    {
        private int TheatherRooms;
        public Cinema(string owner, int id, string schedule, int TheatherRooms) : base(owner, id, schedule)
        {
            this.TheatherRooms1 = TheatherRooms;
        }

        public int TheatherRooms1 { get => TheatherRooms; set => TheatherRooms = value; }
    }
}
