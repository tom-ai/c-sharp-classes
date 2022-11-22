class Student : User, ITalk
{
    public Student(string fn, string ln) : base(fn, ln)
    {

    }

    public override void sayHello()
    {
        Console.WriteLine($"Hi, I am student. My name is {this.FullName}");
    }
}