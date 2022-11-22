public class User : ITalk
{
    public string? FirstName { get; }
    public string? LastName { get; }
    public bool isVerified { get; set; } = false;

    public User(string fn, string ln)
    {
        FirstName = fn; // readonly property accesible from base class
        LastName = ln; // readonly property accesible from base class
    }

    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public virtual void sayHello()
    {
        Console.WriteLine("Hi, I am a general user");
    }

}