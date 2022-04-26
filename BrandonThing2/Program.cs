int pzombibites;
Console.WriteLine();
Console.WriteLine("How many zombies are there on day 1");
var day1zombies = int.Parse(Console.ReadLine());
Console.WriteLine();
Console.WriteLine("How many people can they bite each day");
var zombiebites = Console.ReadLine();

while (int.TryParse(zombiebites, out pzombibites) == false)
{
    Console.WriteLine("Try Again");
    zombiebites = Console.ReadLine();
}

;

Console.WriteLine();
Console.WriteLine("How many days will the invasion last");
var invasionduration = int.Parse(Console.ReadLine());
Console.WriteLine();


/*for (var days = 1; days <= invasionduration && day1zombies * int.Parse(zombiebites) <= 1000000; days++)
{
    day1zombies = day1zombies * zombiebitesp + day1zombies;
    Console.WriteLine("There are " + day1zombies + " zombies at the end of day " + days);
}*/



