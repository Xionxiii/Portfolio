namespace Portfolio.Data.Models;
public class Projects
{
    [Key]
    public int ProjectId { get; set; }

    public string? Name { get; set; } 

    public string? Description { get; set; }

}

