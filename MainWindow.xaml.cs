using System.Collections.ObjectModel;
using System.Windows.Navigation;


namespace KursachNa3
{
    public partial class MainWindow : NavigationWindow
    {
        public MainWindow()
        {
            InitializeComponent();

            App.Current.Resources.Add("buildings", new ObservableCollection<object>());

            DataContext = new MainWindowViewModel();
        }

        public void ButtonsCheck()
        {
                SerialiseButton.IsEnabled = true;
                UseButton.IsEnabled = true;
        }
    }
}
