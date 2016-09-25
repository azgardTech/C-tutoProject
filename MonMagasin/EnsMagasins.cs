using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonMagasin
{
    class EnsMagasins
    {
        public HashSet<Magasin> MyStores { get; set; }

        public EnsMagasins()
        {
            MyStores = new HashSet<Magasin>();
        }

        public void AddStore(Magasin m)
        {
            Boolean ok = false;

            foreach(Magasin mag in this.MyStores.TakeWhile(i=>!ok))
            {
                ok = Magasin.ToCompareStoreId(mag, m);
            }

            if(!ok)
            {
                this.MyStores.Add(m);
                Console.WriteLine("Add product complete with success..." ); }
            else
            { Console.WriteLine("Store already exist..."); }
        }

//********************to complete
        public void DeleteStore(Magasin m)
        { }

        public void SearchStore(Magasin m)
        { }

    }
}
