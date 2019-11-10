using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ItemApp
{
    public class App
    {
        private Action<string> writeline;

        public App(Action<string> writeline)
        {
            this.writeline = writeline;
        }

        public void Run()
        {
            var item = new Item(1111, "Water", "GALLON", 5.0);

            writeline("Item Number\t: " + item.GetItemNo());
            writeline("Item\t\t: " + item.GetDescription());
            writeline("Unit of Measure\t: " + item.GetUnitOfMEasure());
            writeline("Weight\t\t: " + item.GetWeight());
        }
    }
}
