public class Teacher : User
{
    public Teacher(string fn, string ln)
    {
        base.FirstName = fn;
        base.LastName = ln;
    }
    public override void SayHello()
    {
        Console.WriteLine($"Hi, I am a teacher. My name is {this.FullName}");
    }
}