Console.WriteLine("Please enter number day, thank you:");
int day = Convert.ToInt32(Console.ReadLine());
switch(day)
{
    case 1:
        Console.WriteLine("Monday - Working day");
        break;
    case 2:
        Console.WriteLine("Tuesday - Working day");
        break;
    case 3:
        Console.WriteLine("Wednesday - Working day");
        break;
    case 4:
        Console.WriteLine("Thurday - Working day");
        break;
    case 5:
        Console.WriteLine("Friday - Working day");
        break;
    case 6:
        Console.WriteLine("Saturday - Weekend!");
        break;
    case 7:
        Console.WriteLine("Sunday - Weekend!");
        break;
    default:
        Console.WriteLine("No day");
        break;
} 