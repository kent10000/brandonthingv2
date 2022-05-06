
var day = 0;


string? playAgain;
do
{
    Console.Clear();
    Console.WriteLine("How many zombies are there on day 1");
    var day1Zombies = (Console.ReadLine());
    int pday1Zombies;
    while (int.TryParse(day1Zombies, out pday1Zombies) == false)
    {
        Console.WriteLine("Try Again");
        day1Zombies = Console.ReadLine();
    }

    Console.WriteLine();
    Console.WriteLine("How many people can they bite each day");

    var zombieBites = Console.ReadLine();
    int pzombibites;
    while (int.TryParse(zombieBites, out pzombibites) == false)
    {
        Console.WriteLine("Try Again");
        zombieBites = Console.ReadLine();
    }

    Console.WriteLine();
    Console.WriteLine("How many days will the invasion last");
    var invasionDuration = (Console.ReadLine());
    int pinvasionduration;
    while (int.TryParse(invasionDuration, out pinvasionduration) == false)
    {
        Console.WriteLine("Try Again");
        invasionDuration = Console.ReadLine();
    }

    Console.WriteLine();

    var pday1Ombies = pday1Zombies;

    for (var days = 1; days <= pinvasionduration; days++)
    {
        pday1Ombies = (pday1Ombies * pzombibites) + pday1Ombies;
        Console.WriteLine("There are " + pday1Ombies + " zombies at the end of day " + days);
    }

    Console.WriteLine();

    while (pday1Zombies <= 1000000)
    {
        day += 1;
        pday1Zombies = (pday1Zombies * pzombibites) + 1;
        Console.WriteLine("On day, " + day + " there are " + pday1Zombies + " zombies!");
    }

    Console.WriteLine();
    Console.WriteLine("Done! Would you like to go again? ([Y]/N)");
    playAgain = Console.ReadLine();
} while (!(playAgain!.ToLower().Equals("n")));

for (var dc = 0; dc < 10; dc++)
{
    Console.Write("Donkey ");
    Thread.Sleep(200);
}

Console.WriteLine("Bye!");

Thread.Sleep(1000);


