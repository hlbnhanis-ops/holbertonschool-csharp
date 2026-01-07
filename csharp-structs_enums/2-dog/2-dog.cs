using System;
using System.ComponentModel;
using System.Security.Cryptography.X509Certificates;

enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public Dog(string aName, float anAge, string anOwner, Rating aRating)
    {
        name = aName;
        age = anAge;
        owner = anOwner;
        rating = aRating;
    }
}