using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Navigation;

namespace KursachNa3
{
    internal class MainWindowViewModel : DependencyObject
    {
        private RelayCommand? toAddBuildingsPage;

        public RelayCommand ToAddBuildingsPage => toAddBuildingsPage ??=new RelayCommand(obj =>
        {
            (App.Current.MainWindow as MainWindow).Navigate(new Uri("AddBuildingsPage.xaml", UriKind.Relative));
        });

        private RelayCommand? toSerialisePage;

        public RelayCommand ToSerialisePage => toSerialisePage ??=new RelayCommand(obj =>
        {
            (App.Current.MainWindow as MainWindow).Navigate(new Uri("Serialise.xaml", UriKind.Relative));
        });

        private RelayCommand? toDeserialisePage;

        public RelayCommand ToDeserialisePage => toDeserialisePage ??=new RelayCommand(obj =>
        {
            (App.Current.MainWindow as MainWindow).Navigate(new Uri("Deserialise.xaml", UriKind.Relative));
        });

        private RelayCommand? toWorkPage;
        public RelayCommand ToWorkPage => toWorkPage ??=new RelayCommand(obj =>
        {
            (App.Current.MainWindow as MainWindow).Navigate(new Uri("WorkPage.xaml", UriKind.Relative));
        });
    }
}
