//string[] heroes = {"Harry Potter", "Luke Skywalker", "Lara Croft", "Bilbo Baggins", "Scooby-Doo", "Peter Rabbit", "Gamora", "Rocket"};
//string[] villains = {"Voldemort","Darth Vader", "Dracula", "Joker", "Sauron", "Doomsday"};


string folderPath = @"C:\Users\aaruj\Google Drive\!KOOL\!Kool\Programmeerimise alused\data\";
string heroFile = "heroes.txt";
string villainFile = "villains.txt";

string[] heroes = File.ReadAllLines(Path.Combine(folderPath, heroFile));
string[] villains = File.ReadAllLines(Path.Combine(folderPath, villainFile));


string[] weapons = {"plastic fork", "spork", "wooden sword", "magic wand", "m4a1", "lego brick"};


string hero = GetRandomValueFromArray(heroes);
Console.WriteLine($"Today, {hero} saves the day!");


string weapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Our hero has chosen {weapon} to fight off the evil!");


string villain = GetRandomValueFromArray(villains);
Console.WriteLine($"Today, {villain} tries to take over the world!");

string villainweapon = GetRandomValueFromArray(weapons);
Console.WriteLine($"Our villain faces the world with a {villainweapon}!");



static string GetRandomValueFromArray(string[] someArray)
{
    Random rnd = new Random();
    int randomIndex = rnd.Next(0, someArray.Length);
    string randomStringFromArray = someArray[randomIndex];
        return randomStringFromArray;
}