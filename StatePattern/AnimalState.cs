using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class AnimalState : DropState
    {
        private string __label = "Animal";
        public override string Info()
        {
            return this.__label;
        }
        public override void excretion(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("You can move to state -> river");
            Console.ResetColor();
            d.changeState(new RiverState());

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
