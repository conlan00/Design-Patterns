using CommandPattern;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Restaurant
    {
        protected Cuisines cuisine;
        public string? location { set; get; }
        public double averageMealPrice { set; get; }
        public Restaurant(string _location, double _averageMealPrice, Cuisines cuisine)
        {
            this.averageMealPrice = _averageMealPrice;
            this.location = _location;
            this.cuisine = cuisine;
        }
        public void RestaurantInfo()
        {
            switch (cuisine)
            {
                case Cuisines.Asian:
                    averageMealPrice *= 1.2;
                    break;
                case Cuisines.Mexican:
                    averageMealPrice *= 1.4;
                    break;
                case Cuisines.Italian:
                    averageMealPrice *= 1.35;
                    break;
                case Cuisines.American:
                    averageMealPrice *= 1.05;
                    break;
                case Cuisines.French:
                    averageMealPrice *= 2.0;
                    break;
                case Cuisines.Polish:
                    averageMealPrice = averageMealPrice;
                    break;
                default:
                    throw new Exception("No resteurant with this type of food");
            }
            Console.WriteLine($"{cuisine} resteurant located at {location} where a meal costs on average {averageMealPrice}$");

        }
    }

