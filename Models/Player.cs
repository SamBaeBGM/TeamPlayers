using System.ComponentModel.DataAnnotations.Schema;

public class Player {
    public int PlayerId { get; set; }
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string?  Position { get; set; }

    public double Salary { get; set; }

    public string? TeamName { get; set; }

    [ForeignKey("TeamName")]
    public Team? Team { get; set; }
}