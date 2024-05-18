namespace WebDevPath_BackEnd;

class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Hello, Richard!");
        string? hairColor = Console.ReadLine();
        string? numberOfToesString = Console.ReadLine();
        if (!int.TryParse(numberOfToesString, out int numberOfToes))
        {
            return;
        }

        Foot foot = new()
        {
            NumberOfToes = numberOfToes
        };

        Leg leg = new()
        {
            Foot = foot
        };

        Head head = new()
        {
            HairColor = hairColor
        };

        Body body = new()
        {
            Head = head
        };
        body.Legs.Add(leg);



        var test = string.Empty;
    }
}

