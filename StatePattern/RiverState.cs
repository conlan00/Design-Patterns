using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class RiverState : DropState
    {
        private string _label = "River";
        public override string Info()
        {
            return this._label;
        }
        public override void drinking(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> animal");
            Console.ResetColor();
            d.changeState(new AnimalState());
        }
        public override void goingInto(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> ocean");
            Console.ResetColor();
            d.changeState(new OceanState());
        }
        public override void vaporing(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> cloud");
            Console.ResetColor();
            d.changeState(new CloudState());
        }
    }
    

    
}
