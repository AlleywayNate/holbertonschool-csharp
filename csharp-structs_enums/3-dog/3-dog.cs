using System;

public enum Rating
{
    Good,
    Great,
    Excellent
}

struct Dog
{
    public Dog(string Dname, float Dage, string Downer, Rating Drating)
    {
        name = Dname;
        age = Dage;
        owner = Downer;
        rating = Drating;
    }

    public string name;
    public float age;
    public string owner;
    public Rating rating;

    public override string ToString()
    {
        return "Dog Name: " + name + "\n" + "Age: " + age + "\n" + "Owner: " + owner + "\n" + "Rating: " + rating;
    }
}