using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MonMagasin
{
    class Produit
    {
        public int id { get; set; }
        public String libelle { get; set; }
        public String marque { get; set; }
        public String dateDEexp { get; set; }
        public double prix { get; set; }

        public Produit()
        {

        }

        public Produit(int id,String libelle,String marque,String dateEx,double prix)
        {
            this.id = id;
            this.libelle = libelle;
            this.marque = marque;
            this.dateDEexp = dateEx;
            this.prix = prix;
        }

       
          public override String ToString()
        {
            return ("id : "+this.id+"\n libellé : "+this.libelle+"\n marque : "
                +this.marque+"\n date d'expiration : "+this.dateDEexp+"\n prix : "+this.prix);
        }

        public Boolean ToCompare(Produit p)
        {
            return (this.id==p.id && this.libelle==p.libelle && this.marque==p.marque && this.prix==p.prix);
        }

        public static Boolean ToCompare(Produit p1,Produit  p2)
        {
            return (p1.id==p2.id && p1.libelle==p2.libelle && p1.marque==p2.marque && p1.prix==p2.prix);
        }

        public static Produit MakeProduct()
        {
            Produit p = new Produit(Int32.Parse(Program.StringChecker(@"^\d+$", "Id: "))
                ,Program.StringChecker(@"\w{3}","Libellé :")
                ,Program.StringChecker(@"\w{3}","Marque :")
                ,Program.StringChecker(@"^\d{2}-\d{2}-\d{4}$","Date d'expiration :")
                ,Double.Parse(Program.StringChecker(@"^\d+(.\d)?$","Prix :")));
            
            return p; 
        }
    }
}
