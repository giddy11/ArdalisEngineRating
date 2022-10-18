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


var t = new InterestCalculator();

var africanInterestRate = new AfricanNationalityInterestRate(); 

var afr = t.CalculateInterest(africanInterestRate);


class InterestCalculator
{


    //double CalculateInterest(Nationality nationality)
    //{   

    //    switch (nationality)
    //    {
    //        case Nationality.Nigerian:
    //            return 0.1;

    //        case Nationality.NotAfrican:
    //            return 0.2;

    //        case Nationality.African:
    //            return 0.15;

    //        default:
    //            throw new Exception("Nationality Not accounted for");
    //    }
    //}


    public double CalculateInterest(INationalityInterestRate nationalityInterestRate  )
    {
        return nationalityInterestRate.Rate();
    }

       
}


class AfricanNationalityInterestRate : INationalityInterestRate
{
    public double Rate() => 0.15;
}

interface INationalityInterestRate
{
    double Rate();
}

enum Nationality
{
    Nigerian,
    African,
    NotAfrican
}




/*
 we'll start by looking at the program Main, which is the entry point for the app. 

 The result of the Rate method is that a rating prop will be set, if the rating is greater than 0, then the system will output what the rating was.

otherwise, it will specify no rating was produced.
 
 
 class 
 
 
 
 
 
 */