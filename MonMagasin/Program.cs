using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Text.RegularExpressions;

namespace MonMagasin
{
    class Program
    {
     public static String StringChecker(String reg,String msg)
        {
            String str="";
            do
            {
                Console.Clear();
                Console.Write(msg);
                str = Console.ReadLine();
            } while (!Regex.IsMatch(str,reg));
            return str;
        }
        static void Main(string[] args)
        {

            Magasin m = new Magasin(1,"aaaa",20);

            m.h.Add(new Produit(1, "aaa", "aaa", "11-22-2222", 550));
            m.h.Add(new Produit(2, "aaa", "aaa", "11-22-2222", 550));
            m.h.Add(new Produit(3, "aaa", "aaa", "11-22-2222", 550));
         /*   Console.WriteLine("*************************\n\n");
            m.MagasinShow();
            Console.WriteLine("\n\n*************************");*/
            Console.WriteLine(m.SearchProduct(new Produit(3, "aaa", "aaa", "11-22-2222", 550))); 
           /* Console.WriteLine("***************sss**********\n\n");
            m.MagasinShow();
            Console.WriteLine("\n\n*************************");*/
            Console.ReadKey();


        }
    }
}
