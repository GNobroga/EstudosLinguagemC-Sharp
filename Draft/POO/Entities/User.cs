namespace POO.entities;
public class User 
{
    public uint? Id { get; set; }
    public string Name { get; set; }
    public string Email { get; set; }
    public string PasswordHash { get; set; }

    public List<User> Friends = new();

    public User() 
    {}

    public User(uint? id, string name, string email, string passwordHash) 
    {
        Id = id;
        Name = name;
        Email = email;
        PasswordHash = passwordHash;
    }


    public override string ToString()
    {
        return $"Meu nome {Name}";
    }
}