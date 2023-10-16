using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Museum
    {
        public bool guidedTour { set; get; }
        public bool studentDiscount { set; get; }
        public double basicTicketPrice { set; get; }
        public Museum(bool _guidedTour, double _basicTicketPrice, bool _studentDiscount)
        {
            this.guidedTour = _guidedTour;
            this.basicTicketPrice = _basicTicketPrice;
            this.studentDiscount = _studentDiscount;
        }
        public void TotalCost()
        {
            double totalCost = basicTicketPrice;
            if (guidedTour) { totalCost += 10; }
            if (studentDiscount) {  totalCost *= 0.6; }
            Console.WriteLine("Ticket to the National Museum costs " + totalCost + "$");
        }
    }

