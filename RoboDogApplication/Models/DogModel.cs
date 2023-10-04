namespace RoboDogApplication.Models;
public class Dog
{
    public int Age { get; set; }
    public string Name { get; }
    public Breed Breed { get; set; }
    public Dog(int age, string name, Breed breed)
    {
        Age = age;
        Name = name;
        Breed = breed;
    }
}