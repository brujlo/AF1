using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    public abstract class IRetailerAF
    {
        protected abstract ComputersCF FindPC();
        protected abstract DisplaysCF FindDisplay();

        public void GetPC()
        {
            var pc = FindPC();
            var display = FindDisplay();
            Console.WriteLine(this.GetType().Name + " sell " + pc.GetType().Name + " PC's and they use " + display.GetType().Name.Substring(1) + "'' display");
        }
    }


    public class LINKS : IRetailerAF
    {
        protected override ComputersCF FindPC()
        {
            return new ASUS();
        }

        protected override DisplaysCF FindDisplay()
        {
            return new _19();
            //return new _28();
        }
    }

    public class KING : IRetailerAF
    {
        protected override ComputersCF FindPC()
        {
            return new ACER();
        }

        protected override DisplaysCF FindDisplay()
        {
            return new _28();
        }
    }

    public class MSAN : IRetailerAF
    {
        protected override ComputersCF FindPC()
        {
            return new TOSHIBA();
        }

        protected override DisplaysCF FindDisplay()
        {
            return new _19();
        }
    }
}
