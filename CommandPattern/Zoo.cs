using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Zoo
    {
        public int openingTime { get; set; }
        public int closingTime { get; set;}
        public double basicTicketPrice { get; set; }
        protected ZooAttractions zooAttractions;

        public Zoo(int _openingTime, int _closingTime, double _basicticketPrice, ZooAttractions zooAttractions)
        {
            this.openingTime = _openingTime;
            this.closingTime = _closingTime;
            this.basicTicketPrice = _basicticketPrice;
            this.zooAttractions = zooAttractions;   
        }
        public void ZooInfo()
        {
            double specialPrice = basicTicketPrice;
            switch (zooAttractions)
            {
                case (ZooAttractions.TourWithDolphinsShow):specialPrice *= 2; break;
                case (ZooAttractions.GuiderTour): specialPrice *= 1.5; break;
                case (ZooAttractions.GroupTour): specialPrice *= 0.75; break;
                case (ZooAttractions.ClassicTour): specialPrice *= 1; break;
                default: throw new Exception("No such option");
            }
            Console.WriteLine($"Zoo opens at {openingTime} and closes at {closingTime}. The prize for the {zooAttractions} is {specialPrice}$");
        }
    }

