using System.Collections.ObjectModel;
using System.Windows;
using System.Windows.Controls;


namespace KursachNa3
{
    /// <summary>
    /// Логика взаимодействия для AddBuildingsPage.xaml
    /// </summary>
    public partial class AddBuildingsPage : Page
    {
        public AddBuildingsPage()
        {
            InitializeComponent();
        }

        public void SinagogaAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((!double.TryParse((sinagogaFootPrint as TextBox).Text, out double footPrint) || footPrint<1) || (!int.TryParse((sinagogaPlacesCount as TextBox).Text, out int placesCount)||placesCount < 1) ||
                (!double.TryParse((sinagogaServicePrice as TextBox).Text, out double servicePrice)||servicePrice<1) || (!int.TryParse((sinagogaBelieversNumber as TextBox).Text, out int believersNumber)|| believersNumber<1)
                || (!int.TryParse((sinagogaDate as TextBox).Text, out int date)) || date < 1)
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            Sinagoga sinagoga = new Sinagoga(date, footPrint, placesCount, servicePrice, believersNumber);
            (App.Current.Resources["buildings"] as ObservableCollection<object>).Add(sinagoga);
            MessageBox.Show("Синагога добавлена!");
            (App.Current.MainWindow as MainWindow).ButtonsCheck();
        }
        public void ChurchAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((!double.TryParse((churchFootPrint as TextBox).Text, out double footPrint) || footPrint<1) || (!int.TryParse((churchPlacesCount as TextBox).Text, out int placesCount)|| placesCount < 1) ||
                (!double.TryParse((churchServicePrice as TextBox).Text, out double servicePrice)|| servicePrice<1) || (!int.TryParse((churchBelieversNumber as TextBox).Text, out int believersNumber)|| believersNumber<1)
                || (!int.TryParse((churchDate as TextBox).Text, out int date)) || date < 1)
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            Church church = new Church(date, footPrint, placesCount, servicePrice, believersNumber);
            (App.Current.Resources["buildings"] as ObservableCollection<object>).Add(church);
            MessageBox.Show("Церковь добавлена!");
            (App.Current.MainWindow as MainWindow).ButtonsCheck();
        }
        public void MosqueAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((!double.TryParse((mosqueFootPrint as TextBox).Text, out double footPrint)||footPrint < 1) || (!int.TryParse((mosquePlacesCount as TextBox).Text, out int placesCount)|| placesCount < 1) ||
                (!double.TryParse((mosqueServicePrice as TextBox).Text, out double servicePrice)|| servicePrice < 1) || (!int.TryParse((mosqueMonksNumber as TextBox).Text, out int believersNumber) || believersNumber<1)
                || (!int.TryParse((mosqueDate as TextBox).Text, out int date)) || date < 1)
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            Mosque mosque = new Mosque(date, footPrint, placesCount, servicePrice, believersNumber);
            (App.Current.Resources["buildings"] as ObservableCollection<object>).Add(mosque);
            MessageBox.Show("Мечеть добавлена!");
            (App.Current.MainWindow as MainWindow).ButtonsCheck();
        }
        public void CathedralAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((!double.TryParse((cathedralFootPrint as TextBox).Text, out double footPrint) || footPrint < 1) || (!int.TryParse((cathedralPlacesCount as TextBox).Text, out int placesCount) || placesCount<1) ||
                (!double.TryParse((cathedralServicePrice as TextBox).Text, out double servicePrice)|| servicePrice < 1) || (!int.TryParse((cathedralMonksNumber as TextBox).Text, out int believersNumber)|| believersNumber< 1)
                || (!int.TryParse((cathedralDate as TextBox).Text, out int date)) || date < 1)
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            Cathedral cathedral = new Cathedral(date, footPrint, placesCount, servicePrice, believersNumber);
            (App.Current.Resources["buildings"] as ObservableCollection<object>).Add(cathedral);
            MessageBox.Show("Собор добавлен!");
            (App.Current.MainWindow as MainWindow).ButtonsCheck();
        }
        public void PoolAdd_Click(object sender, RoutedEventArgs e)
        {
            if ((!double.TryParse((poolFootPrint as TextBox).Text, out double footPrint) || footPrint<1) || (!int.TryParse((poolDate as TextBox).Text, out int date)) || date<1)
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            Pool pool = new Pool(date, footPrint);
            (App.Current.Resources["buildings"] as ObservableCollection<object>).Add(pool);
            MessageBox.Show("Бассейн добавлен!");
            (App.Current.MainWindow as MainWindow).ButtonsCheck();
        }
        public void MarketAdd_Click(object sender, RoutedEventArgs e)
        {
            if (!int.TryParse((marketPlacesCount as TextBox).Text, out int placesCount) || placesCount < 1)
            {
                MessageBox.Show("Некорректный ввод");
                return;
            }
            OrthodoxMarket market = new OrthodoxMarket(placesCount);
            (App.Current.Resources["buildings"] as ObservableCollection<object>).Add(market);
            MessageBox.Show("Рынок добавлен!");
            (App.Current.MainWindow as MainWindow).ButtonsCheck();
        }
        void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
