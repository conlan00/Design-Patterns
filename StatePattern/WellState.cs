using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
     public class WellState : DropState
    {
        private string _label = "Well";

        public override string Info()
        {
            return this._label;
        }
        public override void drinking(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> human");
            Console.ResetColor();
            d.changeState(new PersonState());
        }
    }
}
