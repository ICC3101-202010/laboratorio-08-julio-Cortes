using Lab8.Controladores;
using System;
using System.Windows.Forms;

namespace Lab8
{
    static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Form1 form1 = new Form1();
            StoreController store = new StoreController(form1);
            RestaurantController restaurant = new RestaurantController(form1);
            CinemaController cinema = new CinemaController(form1);
            RecreationalController recreational = new RecreationalController(form1);
            Application.Run(form1);
        }
    }
}
