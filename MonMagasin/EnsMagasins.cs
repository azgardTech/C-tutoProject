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
            Boolean ok = SearchStore(m);
            if(!ok)
            {
                this.MyStores.Add(m);
                Console.WriteLine("Add product complete with success..." ); }
            else
            { Console.WriteLine("Store already exist..."); }
        }


        public void DeleteStore(Magasin m)
        {
            Boolean ok = false;
            Magasin Mag = new Magasin();
            int i = 0;

            while (!ok && i < MyStores.Count)
            {
                if (Magasin.ToCompareStoreId(MyStores.ElementAt(i), m))
                {
                    Mag = MyStores.ElementAt(i);
                    ok = true;
                }
                i++;
            }

            if (MyStores.Remove(Mag))
            { Console.WriteLine("Store was removed..."); }
            else
            { Console.WriteLine("Store does"); }


        }

        public Boolean SearchStore(Magasin m)
        {
            Boolean ok = false;
            int i = 0;

            while (!ok && i < MyStores.Count)
            {
                if (Magasin.ToCompareStoreId(MyStores.ElementAt(i), m))
                {
                    ok = true;
                }
                i++;
            }

            return ok;

        }

    }
}
