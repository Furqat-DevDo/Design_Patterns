namespace Prototype;
public class Man
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public DateTime BirthDate { get; set; }
    public string? Adress { get; set; }
    public string? Phone { get; set; }
    public string? Email { get; set; }
    public string? FullName => $"{FirstName} {LastName}";
    public string? Gender { get; set; }
    public int Age => (int)((DateTime.Now - BirthDate).TotalDays / 365.25);
    public Man Clone()
    {
        return (Man)this.MemberwiseClone();
    }
    public override string ToString() =>
    $"{FullName} was born on {BirthDate:dd/MM/yyyy} \n Age is {Age} \n Email:{Email} Phone: {Phone} Adress:{Adress}";

}
