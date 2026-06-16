namespace PaintStore.Domain.Models;

public class PaintSpecification
{
    public PaintSpecification(string colour, int sizeInLiters)
    {
        Colour = colour;
        SizeInLiters = sizeInLiters;
    }

    public string Colour { get; set; }

    public int SizeInLiters { get; set; }

    public void DisplaySpecification()
    {
        Console.WriteLine($"Colour: {Colour}, Size: {SizeInLiters}");
    }
}