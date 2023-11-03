namespace _09_Encapsulation.Entity;

public class Person
{
    private DateTime _birthday;
    public string FirstName { get; set; }
    public string LastName { get; set; }

    public Person(string firstName, string lastName, string birthday)
    {
        FirstName = firstName;
        LastName = lastName;
        _birthday = DateTime.ParseExact(birthday, "dd/MM/yyyy", null);
    }

    public string GetFormattedBirthday()
    {
       return _birthday.ToString("MMMM dd, yyyy");
    }
}
