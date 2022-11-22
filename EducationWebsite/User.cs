public class User
{
    public bool isVerified { get; set; } = false;
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }
    
    public virtual void SayHello()
    {
        Console.WriteLine("Hi, I am a general user");
    }

}