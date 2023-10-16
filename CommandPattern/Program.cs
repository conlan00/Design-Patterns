using CommandPattern;

class Program
{
    static void Main(string[] args)
    {
        TripScheduler tr = new TripScheduler();
        Console.WriteLine("=>First trip to Krakow scenario:");
        tr.AddCommand(new TheatreCommand(new Theatre(WeekDay.Monday)));
        tr.AddCommand(new ZooCommand(new Zoo(7, 19, 45, ZooAttractions.ClassicTour)));
        tr.AddCommand(new ResteurantCommand(new Restaurant("Szewska", 25, Cuisines.Italian)));
        tr.AddCommand(new MuseumCommand(new Museum(true, 35.50, true)));
        tr.Trip();
        tr.removeCommands();
        Console.WriteLine("\n=>Second trip to London scenario:");
        tr.AddCommand(new MuseumCommand(new Museum(true, 50, false)));
        tr.AddCommand(new TheatreCommand(new Theatre(WeekDay.Friday)));
        tr.AddCommand(new ResteurantCommand(new Restaurant("Barbican, London", 100, Cuisines.French)));
        tr.AddCommand(new ZooCommand(new Zoo(14, 20, 12, ZooAttractions.GroupTour)));
        tr.Trip();
        tr.removeCommands();
        Console.WriteLine("\n=>Third trip to Los Angeles scenario:");
        tr.AddCommand(new ZooCommand(new Zoo(10, 16, 33, ZooAttractions.TourWithDolphinsShow)));
        tr.AddCommand(new ResteurantCommand(new Restaurant("Long Beach", 80, Cuisines.Mexican)));
        tr.AddCommand(new MuseumCommand(new Museum(false, 21, false)));
        tr.AddCommand(new TheatreCommand(new Theatre(WeekDay.Thursday)));
        tr.Trip();
        tr.removeCommands();
    }
}