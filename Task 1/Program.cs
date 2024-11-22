using System;

class Program
{
    static void Main()
    {
        // Declare variables
        string favoriteBookTitle = "The River and the Source";
        string author = "R.Ogola";
        int numberOfPages = 98;
        bool recommend = true;

        // Print values to the console
        Console.WriteLine("Favorite Book Details:");
        Console.WriteLine($"Title: {favoriteBookTitle}");
        Console.WriteLine($"Author: {author}");
        Console.WriteLine($"Number of Pages: {numberOfPages}");
        Console.WriteLine($"Do I recommend it? {recommend}");
    }
}

