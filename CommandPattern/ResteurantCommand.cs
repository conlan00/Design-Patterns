using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class ResteurantCommand : IVisitTouristAttraction
    {
        protected Restaurant RestaurantVisit;
        public ResteurantCommand(Restaurant RestaurantVisit)
        {
            this.RestaurantVisit = RestaurantVisit;
        }
        public void Visit()
        {
            RestaurantVisit.RestaurantInfo();
        }
    }

