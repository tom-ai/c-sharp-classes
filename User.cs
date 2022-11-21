public class User
{
    public string? FirstName { get; set; }
    public string? LastName { get; set; }
    public string FullName
    {
        get
        {
            return $"{FirstName} {LastName}";
        }
    }

    public override bool Equals(object? obj)
    {
        if (this.FullName == ((User)obj).FullName) // casting it as a user so the parameter is kept more open
        {
            return true;
        }
        return false;
    }

    public override string ToString()
    {
        return this.FullName;
    }
    public static int GetUserPosition(List<User> users, User user)
    {
        for (int i = 0; i < users.Count; i++)
        {
            if (users[i].Equals(user))
            {
                return i;
            }
        }
        return -1;
    }

    public static User GetUserObject(List<User> users, User user)
    {
        foreach (User u in users)
        {
            if (u.Equals(user))
            {
                return u;
            }
        }
        return null;
    }
}