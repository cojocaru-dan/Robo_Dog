using RoboDogApplication.Models;
using RoboDogApplication.Services;

namespace RoboDogApplication.Storage;
public class DogStorage
{
    public DogCreator DogCreator { get; }
    public List<Dog> DogContainer = new();
    public DogStorage(DogCreator dogCreator)
    {
        DogCreator = dogCreator;
    }

    public void AddDog(Dog dog)
    {
        DogContainer.Add(dog);
    }
    public void AddRandomDog()
    {
        DogContainer.Add(DogCreator.@CreateRandomDog());
    }

    public Dog GetRandomDog()
    {
        return DogCreator.@CreateRandomDog();
    }
    public void UpdateDog(string name, Dog newDog)
    {
        foreach (var dog in DogContainer)
        {
            if (dog.Name == name)
            {
                dog.Age = newDog.Age;
                dog.Breed = newDog.Breed;
                return;
            }
        }
    }
}