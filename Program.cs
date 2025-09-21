// User is shown a selection of days to choose.
Console.WriteLine("choose day");
Console.WriteLine("1) sunday");
Console.WriteLine("2) monday");
Console.WriteLine("3) tuesday");
Console.WriteLine("4) wednsday");
Console.WriteLine("5) thursday");
Console.WriteLine("6) friday");
Console.WriteLine("7) saturday");
// this acts as a blank space.
Console.WriteLine();
Console.WriteLine(">>");
string choice = Console.ReadLine();
Console.WriteLine();
//this is how the program writes what day you input and what the message shows.
switch (choice)
{
case "sunday":
        Console.WriteLine("It's the weekend!");
break;
case "monday":
 Console.WriteLine("Aack! I hate Mondays");
break;
case "tuesday":
 Console.WriteLine("It's Tuesday!");
break;
case "wednsday":
         Console.WriteLine("Hump Daaaay!");
break;
case "thursday":
         Console.WriteLine("It's Thursday!");
break;
case "friday":
        Console.WriteLine("TGIF!");
break;
case "saturday":
        Console.WriteLine("It's the weekend!");
break;
}
