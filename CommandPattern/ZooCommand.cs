using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class ZooCommand : IVisitTouristAttraction
    {
        protected Zoo ZooVisit;
        public ZooCommand(Zoo ZooVisit)
        {
            this.ZooVisit = ZooVisit;
        }
        public void Visit()
        {
            ZooVisit.ZooInfo();
        }
    }