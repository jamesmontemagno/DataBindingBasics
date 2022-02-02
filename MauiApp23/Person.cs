using System.ComponentModel;

namespace MauiApp23;

public class Person : INotifyPropertyChanged
{
    string firstName;
    public string FirstName
    {
        get { return firstName; }
        set { firstName = value; OnPropertyChanged(nameof(FirstName)); }
    }
    string lastName;
    public string LastName
    {
        get { return lastName; }
        set { lastName = value; OnPropertyChanged(nameof(LastName)); }
    }
    string email;
    public string Email
    {
        get { return email; }
        set { email = value; OnPropertyChanged(nameof(Email)); }
    }
    string password;
    public string Password
    {
        get => password; set { password = value; OnPropertyChanged(nameof(Password)); }
    }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));


    public void SetProperty(string prop, string val)
    {

    }

    public void ClearFields()
    {
        FirstName = string.Empty;
        LastName = string.Empty;
        Email = string.Empty;
        Password = string.Empty;
    }
}
