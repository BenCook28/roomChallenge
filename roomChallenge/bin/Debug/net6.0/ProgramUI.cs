public class ProgramUI
{
    public void Run()
    {
        calculateAreaTest();
    }
    public decimal calculateAreaTest(decimal length, decimal width, decimal height)
    {
        Console.WriteLine("This program calculates room area.");
        Console.WriteLine("What is the length?");

        decimal roomLength;
        roomLength = Console.ReadLine();

        decimal roomWidth;
        Console.WriteLine("What is the width?");
        roomWidth = Console.ReadLine();

        decimal roomHeight;
        Console.WriteLine("What is the height?");
        roomHeight = Console.ReadLine();

        Room room = new Room();
        room.CalculateArea(roomLength, roomWidth, roomHeight);
    }
}