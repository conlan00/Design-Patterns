using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class OceanState : DropState
    {
        private string _label = "Ocean";
        public override string Info()
        {
            return this._label;
        }
        public override void vaporing(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> Cloud");
            Console.ResetColor();
            d.changeState(new CloudState());
        }

    }
}
