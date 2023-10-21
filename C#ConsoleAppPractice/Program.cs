// See https://aka.ms/new-console-template for more information
Console.Title = "Skynet";
Console.ForegroundColor = ConsoleColor.Green;

Console.WriteLine("Hello, what's your name?");
string userName = Console.ReadLine(); // Warning about a potential null entry
Console.WriteLine("Nice to meet you, " + userName);
Console.WriteLine("What's your favorite color?");
string favColor = Console.ReadLine(); 
Console.WriteLine(favColor + " is a great color!");

Console.WriteLine("Press any key to continue...");
ConsoleKeyInfo keyInfo = Console.ReadKey();
Console.WriteLine($"You pressed the key: {keyInfo.Key}");
