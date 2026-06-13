namespace Paint_Management_System;

public class PaintSpecification
{
    public string Colour { get; set; }

    public int SizeInLiters { get; set; }

    public PaintSpecification(string colour, int sizeInLiters)
    {
        Colour = colour;
        SizeInLiters = sizeInLiters;
    }

    public void DisplaySpecification()
    {
        Console.WriteLine($"Colour: {Colour}, Size: {SizeInLiters}");
    }
}