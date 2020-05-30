using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Controladores
{
    public class RecreationalController
    {
        private List<Recreational> recreationals = new List<Recreational>();
        Form1 form1;
        public RecreationalController(Form1 form1)
        {
            this.form1 = form1;
            this.form1.FinalAddRecreationalClick += OnFinalAddRecreationalClick;
        }
        public List<Recreational> Recreationals { get => recreationals; set => recreationals = value; }
        private bool OnFinalAddRecreationalClick(object source, CreateRecreationalArgs args)
        {
            Recreational recreational = null;
            recreational = Recreationals.Where(u => u.Id == args.id).FirstOrDefault();
            if (recreational is null)
            {
                recreationals.Add(new Recreational(args.ownername, args.id, args.schedule));
                return true;
            }
            else
            {
                return false;
            }
        }

    }
}
