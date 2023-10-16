using StatePattern;

class Program
{
    static void Main(string[] args)
    {
        string check;
        Drop dropOfWater = new Drop();
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.rainFall();
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.drinking();
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.rainFall();
        check = dropOfWater.Info();
        while (check == "Plant") //sometimes plant got stuck in a loop
        {
            Console.WriteLine(dropOfWater.Info());
            dropOfWater.breathing();
            Console.WriteLine(dropOfWater.Info());
            dropOfWater.rainFall();
            check = dropOfWater.Info();
        }
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.drinking();
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.excretion();
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.cleaning();
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.goingInto();
        Console.WriteLine(dropOfWater.Info());
        dropOfWater.vaporing();

    }
}
