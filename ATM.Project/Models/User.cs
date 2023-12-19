using System.ComponentModel.DataAnnotations;

namespace ATM.Project.Models;

public class User
{
    public int Id { get; set; }

    public string FirstName { get; set; }
    
    public string LastName { get; set; }

    [Phone]
    public string PhoneNumber { get; set; }
}
