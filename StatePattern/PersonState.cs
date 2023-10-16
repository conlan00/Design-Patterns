using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{ 
    public class PersonState : DropState
    {
        private string _label = "Human";

        public override string Info()
        {
            return this._label;
        }

        public override void excretion(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> Sewage Farm");
            Console.ResetColor();
            d.changeState(new SewageFarmState());
        }
        public override void breathing(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> Cloud");
            Console.ResetColor();
            d.changeState(new CloudState());
        }

    }
}
