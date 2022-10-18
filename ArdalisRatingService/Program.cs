// See https://aka.ms/new-console-template for more information


Console.WriteLine("Ardalis Insurance Rating System Starting...");

// it simply creates a new RatingEngine type
var engine = new RatingEngine();

// calling the Rate method
engine.Rate();

if (engine.Rating > 0)
{
    Console.WriteLine($"Rating: {engine.Rating}");
}
else
{
    Console.WriteLine("No rating produced.");
}



Console.ReadLine();





/*
 we'll start by looking at the program Main, which is the entry point for the app. 

 The result of the Rate method is that a rating prop will be set, if the rating is greater than 0, then the system will output what the rating was.

otherwise, it will specify no rating was produced.
 
 
 class 
 
 
 
 
 
 */