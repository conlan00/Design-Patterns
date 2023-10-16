using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public  class PlantState :DropState
    {
        private string _label="Plant";

        public override string Info()
        {
            return this._label;
        }
        public override void breathing(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> cloud");
            Console.ResetColor();
            d.changeState(new CloudState());
        }
    }
}

