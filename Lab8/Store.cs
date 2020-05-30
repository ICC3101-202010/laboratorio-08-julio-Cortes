using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public class Store :Local
    {
        private string category;
        public Store(string owner,int id, string schedule,string category):base(owner,id,schedule)
        {
            this.Category = category;
        }

        public string Category { get => category; set => category = value; }
    }
}
