
Console.Clear();
int choice;
seasons todo;

Console.WriteLine("Please Choose A Season by entering the corresponding number");
Console.WriteLine("1. Winter");
Console.WriteLine("2. Spring");
Console.WriteLine("3. Summer");
Console.WriteLine("4. Fall");

while (true)
{
    try
    {
        choice = int.Parse(Console.ReadLine());
        if (choice >= 1 && choice <= 4)
        {
            todo = (seasons)choice;
            break;
        }
        else
        {
            Console.Write("Please enter a value 1-4: ");
        }
    }
    catch
    {
        Console.Write("Please enter a valid integer: ");
    }
}
Console.WriteLine(activity(todo));

string activity(seasons season)
{
    switch (season)
    {
        case seasons.Winter:
            return "Go Skiing";
        case seasons.Spring:
            return "Enjpoy the Blooming flowers";
        case seasons.Summer:
            return "Go to the beach";
        case seasons.Fall:
            return "Visit the Pumpkin patch";
        default:
            break;
    }
    return "";
}

public enum seasons
{
    Winter = 1,
    Spring,
    Summer,
    Fall
}