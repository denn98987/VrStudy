using System.Collections.ObjectModel;

namespace vrstud
{
    public class CommonPViewModel : ViewModelBase
    {
        public CommonPViewModel()
        {
            Groups = new ObservableCollection<Group>(new Groups().GroupsData);
            Students = new ObservableCollection<Student>(new Students().StudentsData);
            Account = new AccountDescription();
        }

        public ObservableCollection<Group> Groups { get; set; }
        public ObservableCollection<Student> Students { get; set; }
        public AccountDescription Account { get; set; }
    }
}