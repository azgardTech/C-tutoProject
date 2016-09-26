using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonMagasin
{
    class Magasin
    {
        public int id { get; set; }
        public String adresse { get; set; }
        public int capacite { get; set; }
        public HashSet<Produit> h { get; set; }

        public Magasin()
        {
        }

        public Magasin(int id,String adresse,int capacite)
        {
            this.id = id;
            this.adresse = adresse;
            this.capacite = capacite;
            h = new HashSet<Produit>();      
        }

        public static Magasin MakeMagasin()
        {
            Magasin m = new Magasin(Int32.Parse(Program.StringChecker(@"^\d+$", "id: "))
                ,Program.StringChecker(@"\w+","adresse: ")
                ,Int32.Parse(Program.StringChecker(@"^\d+$","Capacité: ")));


            return m;
        }


        public void MagasinShow()
        {
            Console.WriteLine("*****Store**** \n id: " + this.id + "\n adress: " + this.adresse
                + "\n capacité: " + this.capacite);
            foreach (Produit p in this.h)
            {
                Console.WriteLine("------------------------");
                Console.WriteLine(p.ToString());
            }

        }


        public void AddProduct(Produit p)
        {
            if (SearchProduct(p))
            { Console.WriteLine("Product already exist..."); }
            else
            { h.Add(p);
                Console.WriteLine("Product added successfully..."); }


        }


        public void DeleteProduct(Produit p)
        {
            Boolean ok = false;
            int i = 1;
            Produit prd = new Produit();

            while (!ok && i < h.Count)
            {
                if (h.ElementAt(i).ToCompare(p))
                { ok = true;
                  prd = h.ElementAt(i);
                }
                i++;
            }
            if (h.Remove(prd))
            { Console.WriteLine("Product was removed successfully..."); }
            else
            { Console.WriteLine("Product does not exist..."); }

        }
        

        public Boolean SearchProduct(Produit p)
        {
            Boolean ok = false;
            int i = 0;

            while (!ok && i < this.h.Count)
            {
                
                if (h.ElementAt(i).ToCompare(p))
                {
                    ok = true;
                }
                i++;
            }
            return ok;
        }


        public static void ToCompareNbrProducts(Magasin m1, Magasin m2)
        {
            if (m1.h.Count() < m2.h.Count())
            { Console.WriteLine("Store with id "+m2.id+" has more products"); }
            else
            {
                if (m1.h.Count() == m2.h.Count())
                { Console.WriteLine("Store 1 and 2 have the same number of products"); }
                else
                {
                    if (m1.h.Count() > m2.h.Count())
                    { Console.WriteLine("Store with id " + m1.id + " has more products"); }
                }
            }

  
        }

        public static Boolean ToCompareStoreId(Magasin m1, Magasin m2)
        {
            return (m1.id == m2.id && m1.adresse == m2.adresse && m1.capacite == m2.capacite);
        }





    }
}
