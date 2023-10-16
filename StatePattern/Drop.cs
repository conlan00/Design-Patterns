using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StatePattern
{
    public class Drop //context
    {
        private DropState State;
        public Drop()
        {
            State = new CloudState();//initial state 
        }
        public string Info()
        {
            return State.Info();
        }

        public void changeState(DropState state)
        {
            State = state;
        }

        public void breathing()
        {
            State.breathing(this);
        }
        public void rainFall()
        {
            State.rainFall(this);
        }

        public void drinking()
        {
            State.drinking(this);
        }
        public void cleaning()
        {
            State.cleaning(this);
        }
        public void excretion()
        {
            State.excretion(this);
        }
        public void goingInto()
        {
            State.goingInto(this);
        }
        public void vaporing()
        {
            State.vaporing(this);
        }
    }
}
