public class LeaveRequest
{
    public int Id { get; set; }
    public string Who { get; set; } = string.Empty;
    public DateTime When { get; set; }
    public DateTime ComeBack { get; set; }
    public bool IsApproved { get; set; }
}