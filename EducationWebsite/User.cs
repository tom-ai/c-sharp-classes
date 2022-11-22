public abstract class User
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

    // Abstract class with abstract method
    // forces derived class to have an implementation of SayHello()
    public abstract void SayHello();

}