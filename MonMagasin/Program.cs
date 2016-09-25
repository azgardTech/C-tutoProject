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

            Produit p = Produit.MakeProduct();
            Console.WriteLine("***************");
            Console.WriteLine(p.ToString());
            Console.ReadKey();
 

        }
    }
}
