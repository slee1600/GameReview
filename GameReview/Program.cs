using System;
using System.Linq;
using GameReview;
using static GameReview.Utilities;

using var db = new DatabaseContext();

//Create new game record
Console.Write("Enter a new Game Title and press 'Enter' - ");
var name = Console.ReadLine();
Game game = new();

if (!string.IsNullOrEmpty(name))
{
    if (game.CreateNewItem(name))
    {
        Console.WriteLine("New record added");
        Log("New Record Added: " + name);
        Console.WriteLine();
    }
}

// Read
Console.WriteLine("Retrieving Master List of Games");

if (db.Games != null)
{
    var list = db.Games.Select(g => g.Title).ToList();
    var allBlogs = db.Games;
    list.ForEach(x => Console.WriteLine(x));
    Console.WriteLine();
}

// Add Review Update
Console.Write("Enter a Title for the New Game Review -");
var title = Console.ReadLine();

Console.Write("Enter your Comments, and press 'Enter' - ");
var reviewContent = Console.ReadLine();

Review review = new Review();

if (!string.IsNullOrEmpty(title) && !string.IsNullOrEmpty(reviewContent))
{
    if (review.AddNewReview(game, title, reviewContent))
    {
        Console.Write("Review update added to game");
        Log("New Review Record Added: " + title + " " + reviewContent);
        Console.WriteLine();
    }
}

// Delete single record
Console.WriteLine("Press 'y' to remove the current game review or any other key to preserve it");
ConsoleKeyInfo RevKey = Console.ReadKey();

if (RevKey.Key.ToString().ToLower() == "y")
{
    if (!string.IsNullOrEmpty(name))
    {
        if (game.DeleteNewGame(name))
            Console.Write("New record removed");
        Log("New Record Deleted: " + name);
    }
}
else
{
    Console.Write("Record preserved");
    Console.WriteLine();
}

//Delete All of the games
Console.WriteLine("Press 'y' to delete all of the records or any other key to skip");
ConsoleKeyInfo ra = Console.ReadKey();

if (ra.Key.ToString().ToLower() == "y")
{
    if(name != null)
    { Console.WriteLine("Removing all of the games from the system"); game.DeleteAllGames();}    
}
else
{
    Console.WriteLine("All records preserved");
}

