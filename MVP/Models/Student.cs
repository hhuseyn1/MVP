namespace MVP.Models;
public class Student
{
    public Guid Id { get; set; }
    public string FirstName { get; set; } = default!;
    public string LastName { get; set; } = default!;
    public DateTime BirthOfDate { get; set; }
    public float Score { get; set; }
    public Student()
    {
        Id = Guid.NewGuid();
    }
    public Student(string firstName,string lastName, DateTime birtofDate,float score):this()
    {
        FirstName = firstName;
        LastName = lastName;
        BirthOfDate = birtofDate;
        Score = score;
    }
    public override string ToString()
        => @$"{Id.ToString().Remove(8)} {FirstName} {LastName} {BirthOfDate} {Score}";
}
