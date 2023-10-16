using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class MuseumCommand : IVisitTouristAttraction
    {
        protected Museum MuseumVisit;
        public MuseumCommand(Museum MuseumVisit)
        {
            this.MuseumVisit = MuseumVisit;
        }
        public void Visit()
        {
            MuseumVisit.TotalCost();
        }
    }

