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
            Boolean ok = false;
            foreach(Produit prd in this.h.TakeWhile(i=>!ok))
            { ok = Produit.ToCompare(p, prd); }

            if(!ok)
            {
              this.h.Add(p);
              Console.WriteLine("Add product complete with success...");
            }
            else
            { Console.WriteLine("Product already exist"); }
            
        }


        public void DeleteProduct(Produit p)
        {
            Boolean ok = false;
            foreach(Produit prd in this.h.TakeWhile(i=>!ok))
            { ok = Produit.ToCompare(p, prd);
                if(ok)
                { this.h.Remove(prd); }
            }
        }

        public Boolean SearchProduct(Produit p)
        {
            Boolean ok = false;
            foreach(Produit prd in this.h.TakeWhile(i=>!ok))
            { ok = Produit.ToCompare(prd, p); }
            return ok;
        }





    }
}
