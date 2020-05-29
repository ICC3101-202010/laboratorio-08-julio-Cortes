using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Restaurant: Local
    {
        private bool privatetables;
        public Restaurant(string owner, int id, string schedule, bool privatetables):base(owner,id,schedule)
        {
            this.privatetables = privatetables;
        }
    }
}
