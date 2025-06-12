namespace Kindergarten.Domain.Entities;
public class Child
{
    public int Id { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public int Age { get; set; }
    public int GuardianId { get; set; }
    public Guardian Guardian { get; set; }
}
