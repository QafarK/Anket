namespace Anket;

public class Person
{
    public string TitleName { get; set; }
    public string Name { get; set; }
    public string Surname { get; set; }
    public string MiddleName { get; set; }
    public string Country { get; set; }
    public string City { get; set; }
    public string Phone { get; set; }
    public string BirhtDate { get; set; }
    public string Gender { get; set; }

    public Person(string titleName, string name, string surname, string middleName, string country, string city, string phone, string birhtDate, string gender)
    {
        TitleName = titleName;
        Name = name;
        Surname = surname;
        MiddleName = middleName;
        Country = country;
        City = city;
        Phone = phone;
        BirhtDate = birhtDate;
        Gender = gender;
    }
}
