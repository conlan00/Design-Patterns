using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class SewageFarmState: DropState
    {
        private string _label = "Sewage Farm";
        public override string Info()
        {
            return this._label;
        }

        public override void cleaning(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> river");
            Console.ResetColor();
            d.changeState(new RiverState());
        }

    }
}
