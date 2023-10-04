using RoboDogApplication.Models;
namespace RoboDogApplication.Services;

public class DogCreator
{
    private static int dogNr = 0;
    private static readonly Random rand = new();
    public Dog @CreateRandomDog()
    {
        int age = GetRandomAge();
        Breed breed = GetRandomBreed();
        string name = GetRandomName(breed);
        return new Dog(age, name, breed);
    }
    public int GetRandomAge() => rand.Next(16);
    public string GetRandomName(Breed breed) 
    {
        dogNr += 1;
        return breed.ToString() + dogNr; 
    }
    public Breed GetRandomBreed()
    {
        Breed[] breeds = Enum.GetValues<Breed>();
        return breeds[rand.Next(breeds.Length)];
    }
}