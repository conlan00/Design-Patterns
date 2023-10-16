using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class TheatreCommand : IVisitTouristAttraction
    {
        protected Theatre TheatreVisit;
        public TheatreCommand(Theatre TheatreVisit)
        {
            this.TheatreVisit = TheatreVisit;
        }
        public void Visit()
        {
            TheatreVisit.PlayedArt();
        }
    }
