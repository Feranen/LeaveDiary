public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
    private static int Counter = -1;
    public User()
    {
        Counter++;
    }
    public static int GetCounter()
    {
        Console.WriteLine(Counter);
        return Counter;
    }
    public override string ToString()
    {
        return $"Id = {this.Id}, Name = {this.Name}";
    }
}
