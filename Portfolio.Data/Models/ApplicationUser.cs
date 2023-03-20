namespace Portfolio.Data.Models;

public class ApplicationUser
{
    public int ApplicationUserId { get; set; }

    public string? Name { get; set; }

    public DateTime? BirthDate { get; set; }

    public bool IsAdmin { get; set; } = false;

    public string? Email { get; set; }


}
