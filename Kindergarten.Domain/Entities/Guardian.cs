namespace Kindergarten.Domain.Entities;
public class Guardian
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string PhoneNumber { get; set; }

    public ICollection<Child> Children { get; set; }
}
