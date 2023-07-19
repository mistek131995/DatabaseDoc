using System.ComponentModel.DataAnnotations;

namespace Contracts.Models;

public class User
{
    [Key]
    public Guid Id { get; set; }
    public string Name { get; set; }
    public string Password { get; set; }
    public string Email { get; set; }
}