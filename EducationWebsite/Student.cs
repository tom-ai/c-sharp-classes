class Student : User
{
    public Student(string fn, string ln)
    {
        base.FirstName = fn;
        base.LastName = ln;
    }
    public override void SayHello()
    {
        Console.WriteLine($"Hi, I am student. My name is {this.FullName}");
    }
}