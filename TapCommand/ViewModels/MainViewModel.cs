using System.Collections.ObjectModel;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.Command;
using TapCommand.Models;

namespace TapCommand.ViewModels
{
    public class MainViewModel : ViewModelBase
    {
        private ObservableCollection<Person> _persons = new ObservableCollection<Person>();
        public ObservableCollection<Person> Persons
        {
            get { return _persons; }
            set { Set(() => Persons, ref _persons, value); }
        }

        private Person _selectedItem;
        public Person SelectedItem
        {
            get { return _selectedItem; }
            set { Set(() => SelectedItem, ref _selectedItem, value); }
        }

        private RelayCommand<Person> _gridClickedCommand;
        public RelayCommand<Person> GridClickedCommand => _gridClickedCommand ?? (_gridClickedCommand = new RelayCommand<Person>((item) => OnGridClicked(item)));

        private void OnGridClicked(Person item)
        {
            //TODO: Look a cast exception!
            var t = item;
        }

        public MainViewModel()
        {

        }
    }
}
