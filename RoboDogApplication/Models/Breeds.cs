using System.Text.Json.Serialization;

namespace RoboDogApplication.Models;
[JsonConverter(typeof(JsonStringEnumConverter))]
public enum Breed
{
    Labrador,
    Rottweiler,
    German_Sheperd,
    Akita,
    Border_Collie
}