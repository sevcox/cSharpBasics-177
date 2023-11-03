namespace _09_Abstraction.Entity;

public class Person
{
    private readonly DateTime _birthday;
    private readonly string _firstName;
    private readonly string _lastName;

    public Person(string firstName, string lastName, string birthday)
    {
        _firstName = firstName;
        _lastName = lastName;
        _birthday = DateTime.ParseExact(birthday, "dd/MM/yyyy", null);
    }

    public string GetName()
    {
        return $"I am {_firstName} {_lastName}";
    }

    public string GetAge()
    {
        return $"I am {CalculateAge()}";
    }

    private int CalculateAge()
    {
        int age = DateTime.Today.Year - _birthday.Year;
        // validation
        return age;
    }
}
