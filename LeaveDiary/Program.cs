internal class Program
{
    private static void Main(string[] args)
    {
        var user1 = new User();
        var user2 = new User();

        var request = new LeaveRequest();

        user1.Id = 1;
        user2.Id = user1.Id + 1;

        user1.Name = "Yaroslav";
        user2.Name = "Ewa";


        Console.WriteLine($"user1 id - {user1.Id} and name - {user1.Name}");
        Console.WriteLine($"user2 id - {user2.Id} and name - {user2.Name}");
    }
}

public class User
{
    public int Id { get; set; }
    public string Name { get; set; } = string.Empty;
}

public class LeaveRequest
{
    public int Id { get; set; }
    public string Who { get; set; } = string.Empty;
    public DateTime When { get; set; }
    public DateTime ComeBack { get; set; }
    public bool IsApproved { get; set; }
}