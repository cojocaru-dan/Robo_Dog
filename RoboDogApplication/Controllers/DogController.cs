using Microsoft.AspNetCore.Mvc;
using RoboDogApplication.Models;
using RoboDogApplication.Storage;

namespace RoboDogApplication.Controllers;
[ApiController]
public class DogController
{
    public DogStorage DogStorage { get; }
    public DogController(DogStorage dogStorage)
    {
        DogStorage = dogStorage;
    }

    [Route("AllDogs")]
    public ContentResult GetAllDogs()
    {
        string dogsAsStringHTML = "";
        foreach (var dog in DogStorage.DogContainer)
        {
            dogsAsStringHTML += $"<p>{dog.Name} {dog.Age} years breed {dog.Breed}</p>";
        }
        return new ContentResult() 
        {
            Content = dogsAsStringHTML,
            ContentType = "text/html"
        };
    }

    [Route("RandomDog")]
    public ContentResult GetRandomDog()
    {
        Dog randomDog = DogStorage.GetRandomDog();
        return new ContentResult()
        {
            Content = $"<p>{randomDog.Name}, {randomDog.Age} years, breed: {randomDog.Breed}</p>",
            ContentType = "text/html"
        };
    }

    [Route("AddDog")]
    public ContentResult AddDog([FromBody]Dog newDog)
    {
        DogStorage.AddDog(newDog);
        return new ContentResult()
        {
            Content = "Dog was Added successfully!",
            ContentType = "text/plain"
        };
    }
    [Route("UpdateDog/{name}")]
    public ContentResult UpdateDog([FromRoute]string name, [FromBody]Dog newDog)
    {
        DogStorage.UpdateDog(name, newDog);
        return new ContentResult()
        {
            Content = "Dog was Updated successfully!",
            ContentType = "text/plain"
        };
    }
}