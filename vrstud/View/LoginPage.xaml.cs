using System.Windows.Controls;

namespace vrstud.View
{
    public partial class LoginPage : Page
    {
        private readonly LoginViewModel ViewModel = new LoginViewModel();

        public LoginPage()
        {
            DataContext = ViewModel;
            InitializeComponent();
        }
    }
}