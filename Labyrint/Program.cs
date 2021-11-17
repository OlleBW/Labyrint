using System;

string room = "1";
    
Console.WriteLine("Hello and welcome to the maze!");
Console.WriteLine("You are standing in room 1");
Console.WriteLine("There is a door in front of you");

while (room != "end")
{
    while (room == "1")
    {
        Console.WriteLine("Do you wish to enter?");
        string choise = Console.ReadLine();
        choise = choise.ToLower();
      
        if (choise == "yes")
        {
            Console.Clear();
            room = "2";
            Console.WriteLine("You are now in room 2");
        }
        if (choise == "no")
        {
            Console.WriteLine("");
        }
    }
}


Console.ReadLine();