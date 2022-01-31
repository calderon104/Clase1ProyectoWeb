public class User
{
    public  String Name { get; set; }
    public string Surname { get; set; }


public User()
{
    
}
public User (string name, string surname)
{
    Name = name;
    Surname = surname;  
}
public String FullName()
{
    return $"{Name} {Surname}";
}
}