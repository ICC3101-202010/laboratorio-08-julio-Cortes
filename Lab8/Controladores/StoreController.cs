using System;
using System.Collections.Generic;
using System.Linq;

namespace Lab8.Controladores
{
    public class StoreController
    {
        private List<Store> stores= new List<Store>();
        Form1 form1;
        public StoreController(Form1 form1)
        {
            this.form1 = form1;
            this.form1.FinalAddStoreClick += OnFinalAddStoreClick;
            this.form1.LoadStores += OnLoadStores;
        }

        private List<Store> OnLoadStores(object source, LocalInfoArgs args)
        {
            return stores;
        }

        public List<Store> Stores { get => stores; set => stores = value; }

        private bool OnFinalAddStoreClick(object sender, CreateStoreArgs e)
        {
            Store store = null;
            store = Stores.Where(u =>u.Id==e.id).FirstOrDefault();
            if (store is null)
            {
                stores.Add(new Store(e.ownername, e.id, e.schedule, e.category));
                return true;
            }
            else
            {
                return false;
            }
        }
    }

}
