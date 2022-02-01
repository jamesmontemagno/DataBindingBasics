using System.Windows.Input;

namespace MauiApp23;

public  class PersonPageViewModel
{
    public PersonPageViewModel()
    {
        PostPeople = new Command(AddPerson);

        var People = new Person()
        {
            FirstName = firstName,
            LastName = lastName,
            Email = mail,
            Password = password
        };
    }
    public string firstName;
    public string lastName;
    public string mail;
    public string password;
    public ICommand PostPeople { get; }
    public static void AddPerson()
    {
        //Submit new user to database
        var newUser = new Person();
        newUser.SetProperty("login", firstName);
        newUser.Password = password;
    }
}
