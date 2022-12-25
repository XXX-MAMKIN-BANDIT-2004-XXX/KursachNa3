
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows;
using System.Windows.Controls;


namespace KursachNa3
{
    public partial class Deserialise : Page
    {
        public Deserialise()
        {
            InitializeComponent();
        }
        void Deserialise_Click(object sender, RoutedEventArgs e)
        {
            var fn = fileName.Text;

            BinaryFormatter bf = new();
            try
            {
                using (FileStream fs = new(fn, FileMode.Open))
                {
                    App.Current.Resources["buildings"] = bf.Deserialize(fs);

                    MessageBox.Show("Загружено!");
                }
            }
            catch
            {
                MessageBox.Show("Путь к папке введён неверно");
            }
            finally
            {
                (App.Current.MainWindow as MainWindow).ButtonsCheck();
            }
        }
        void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
