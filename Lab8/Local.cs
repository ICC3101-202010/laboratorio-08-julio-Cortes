﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8
{
    public abstract class Local
    {
        string owner;
        int id;
        string schedule;
        public Local(string owner,int id, string schedule)
        {
            this.owner = owner;
            this.id = id;
            this.schedule = schedule;
        }
    }
}
