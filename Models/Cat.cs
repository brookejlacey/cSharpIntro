namespace dotnetCats.Models;

public class Cat
{

    public string Id { get; set; } = Guid.NewGuild().ToString();
}