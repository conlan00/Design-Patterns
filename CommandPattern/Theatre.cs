using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


    class Theatre
    {
        protected WeekDay weekDay;
        public Theatre(WeekDay weekDay)
        {
            this.weekDay = weekDay;

        }
        public void PlayedArt()
        {
            switch (weekDay)
            {
                case WeekDay.Monday:
                    Console.WriteLine("Today's art is Hamlet by William Shakespeare");
                    break;
                case WeekDay.Tuesday:
                    Console.WriteLine("Today's art is Long Day's Journey Into Night Eugene O'Neill");
                    break;
                case WeekDay.Wednesday:
                    Console.WriteLine("Today's art is Who's Afraid of Virginia Woolf? by Edward Albee");
                    break;
                case WeekDay.Thursday:
                    Console.WriteLine("Today's art is Death of a Salesman by Arthur Miller");
                    break;
                case WeekDay.Friday:
                    Console.WriteLine("Today's art is Romeo and Julia by William Shakespeare");
                    break;
                case WeekDay.Saturday:
                    Console.WriteLine("Today's art is Oedipus Rex by Sophocles");
                    break;
                case WeekDay.Sunday:
                    Console.WriteLine("Today's art is Angels in America by Tony Kushner");
                    break;
                default:
                    throw new Exception("Wrong input");
            }
        }
    }

