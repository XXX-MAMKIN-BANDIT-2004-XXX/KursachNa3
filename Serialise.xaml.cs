
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;


namespace KursachNa3
{
    public partial class Serialise : Page
    {
        public Serialise()
        {
            InitializeComponent();
        }

        public void Serialise_Click(object sender, RoutedEventArgs e)
        {
            string fn = fileName.Text;

            BinaryFormatter bf = new();
            using (FileStream fs = new(fn, FileMode.Create))
            {
                bf.Serialize(fs, App.Current.Resources["buildings"]);

                MessageBox.Show("Сохранено в файле " + fn);
            }
        }
        void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }

    }
}
