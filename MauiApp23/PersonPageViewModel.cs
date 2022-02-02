using System.ComponentModel;
using System.Windows.Input;

namespace MauiApp23;

public  class PersonPageViewModel : INotifyPropertyChanged
{
    public Person Person { get; } = new Person();
    public PersonPageViewModel()
    {
        PostPeople = new Command(AddPerson);        
    }

    public ICommand PostPeople { get; }

    public event PropertyChangedEventHandler PropertyChanged;

    void OnPropertyChanged(string name) =>
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(name));

    public void AddPerson()
    {
        //add to database!
        Person.ClearFields();
    }
}
