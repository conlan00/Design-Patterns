using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class CloudState : DropState
    {
        private string _label = "Cloud";
        Random rand = new Random();
        public override string Info()
        {
            return this._label;
        }
        public override void rainFall(Drop d)
        {
            int value = rand.Next(1, 4);
            switch (value)
            {
                case 1:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You can move to state-> plant");
                    Console.ResetColor();
                    d.changeState(new PlantState());
                    break;
                case 2:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You can move to state -> well");
                    Console.ResetColor();
                    d.changeState(new WellState());
                    break;
                case 3:
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("You can move to state -> river");
                    Console.ResetColor();
                    d.changeState(new RiverState());
                    break;

            }
        }
    }
}
