using System;

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

    public override string ToString()
    {
        return String.Format("Dog Name: {0}\nAge: {1}\nOwner: {2}\nRating: {3}", name, age, owner, rating);
    }
}