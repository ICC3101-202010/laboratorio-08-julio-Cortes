using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab8.Controladores
{
    public class CinemaController
    {
        private List<Cinema> cinemas = new List<Cinema>();
        Form1 form1;
        public CinemaController(Form1 form1)
        {
            this.form1 = form1;
            this.form1.FinalAddCinemaClick += OnFinalAddCinemaClick;
            this.form1.LoadCinema += OnLoadCinema;
        }

        private List<Cinema> OnLoadCinema(object source, LocalInfoArgs args)
        {
            return cinemas;
        }

        public List<Cinema> Cinemas { get => cinemas; set => cinemas = value; }

        private bool OnFinalAddCinemaClick(object source, CreateCinemaArgs args)
        {
            Cinema cinema = null;
            cinema = Cinemas.Where(u => u.Id == args.id).FirstOrDefault();
            if (cinema is null)
            {
                cinemas.Add(new Cinema(args.ownername, args.id, args.schedule, args.nrooms));
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
