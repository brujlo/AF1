using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {

        enum SELLER
        {
            LINKS,
            KING,
            MSAN
        }
        class SellerChecker
        {
            IRetailerAF ret;
            SELLER manu;

            public void CheckProducts(SELLER sell)
            {
                switch (sell)
                {
                    case SELLER.LINKS:
                        ret = new LINKS();
                        break;
                    case SELLER.KING:
                        ret = new KING();
                        break;
                    case SELLER.MSAN:
                        ret = new MSAN();
                        break;
                }
                ret.GetPC();
            }
        }


        static void Main(string[] args)
        {
            SellerChecker checker = new SellerChecker();
            checker.CheckProducts(SELLER.LINKS);
            checker.CheckProducts(SELLER.KING);
            Console.ReadLine();

            IRetailerAF ret1 = new LINKS();
            ret1.GetPC();
            Console.ReadLine();

            IRetailerAF ret2 = new KING();
            ret2.GetPC();
            Console.ReadLine();

            IRetailerAF ret3 = new MSAN();
            ret3.GetPC();
            Console.ReadLine();
        }
    }
}
