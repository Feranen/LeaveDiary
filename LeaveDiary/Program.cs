using System.Diagnostics.Metrics;

internal class Program
{
    private static void Main(string[] args)
    {
        var user1 = new User();
        User.GetCounter();
        var user2 = new User();
        User.GetCounter();

        var request = new LeaveRequest();

        user1.Id = 1;

        user2.Id = user1.Id + 1;

        user1.Name = "Yaroslav";
        user2.Name = "Ewa";


        //Console.WriteLine($"user1 id - {user1.Id} and name - {user1.Name}");
        //Console.WriteLine($"user2 id - {user2.Id} and name - {user2.Name}");

        Console.WriteLine(user1.ToString());
        Console.WriteLine(user2.ToString());
    }
}
