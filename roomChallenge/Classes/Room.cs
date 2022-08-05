public class Room
{
    public decimal roomLength { get; set; }
    public decimal roomWidth { get; set; }
    public decimal roomHeight { get; set; }

    public decimal CalculateArea(decimal length, decimal width, decimal heigth)
    {
        decimal area = length * width * heigth;
        return area;
    }
}

