using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public abstract class DropState
    {
        public virtual void breathing(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot move through breathing");
            Console.ResetColor();
        }
        public virtual void rainFall(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot move through rainFall");
            Console.ResetColor();
        }
        public virtual void drinking(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot move through drinking");
            Console.ResetColor();
        }
        public virtual void cleaning(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot move through cleaning");
            Console.ResetColor();
        }
        public virtual void excretion(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot move through excretion");
            Console.ResetColor();
        }
        public virtual void goingInto(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot move through goingInto");
            Console.ResetColor();
        }
        public virtual void vaporing(Drop d)
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("You cannot move through vaporing");
            Console.ResetColor();
        }
        public abstract string Info();
    }
}
