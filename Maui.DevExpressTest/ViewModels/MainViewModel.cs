using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows.Input;

using Maui.DevExpressTest.Models;

namespace Maui.DevExpressTest.ViewModels
{
    public class MainViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private ObservableCollection<string> items;

        public ObservableCollection<string> Items
        {
            get
            {
                return this.items;
            }
            set
            {
                this.items = value;
                OnPropertyChanged();
            }
        }

        private ObservableCollection<Person> persons;

        public ObservableCollection<Person> Persons
        {
            get
            {
                if (this.persons == null)
                {
                    this.persons = new ObservableCollection<Person>();
                }

                return this.persons;
            }
            set
            {
                this.persons = value;
                OnPropertyChanged();
            }
        }

        public ICommand MenuCommand => new Command<string>(p => OnMenuCommand(p));

        private void OnMenuCommand(string menu)
        {
            Shell.Current.GoToAsync("//App/" + menu);
        }

        public MainViewModel()
        {
            Items = new ObservableCollection<string>() { "Milk", "Tea", "Coffee" };

            Persons.Add(new Person() { Name = "Devid", Age = 45, Location = "Atlanta" });
            Persons.Add(new Person() { Name = "Bernda", Age = 23, Location = "Memphis" });
            Persons.Add(new Person() { Name = "Sean", Age = 36, Location = "Hiuston" });
        }
    }
}
