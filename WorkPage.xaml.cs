using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace KursachNa3
{
    public partial class WorkPage : Page
    {
        public WorkPage()
        {
            InitializeComponent();

            Buildings = App.Current.Resources["buildings"] as ObservableCollection<object>;
            buildings.ItemsSource = Buildings;
        }

        public object SelectedBuilding
        {
            get { return (object)GetValue(SelectedBuildingProperty); }
            set { SetValue(SelectedBuildingProperty, value); }
        }
        public static readonly DependencyProperty SelectedBuildingProperty =
            DependencyProperty.Register("SelectedBuilding", typeof(object), typeof(WorkPage), new PropertyMetadata(null));

        public ObservableCollection<object> Buildings { get; }

        delegate object? DrinkDelegate(object? obj, object?[]? par = null);

        private void ComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            SelectedBuilding = (sender as ComboBox).SelectedItem;

            Out.Text = "";
            methods.Children.Clear();

            if (SelectedBuilding != null)
            {
                foreach (var item in SelectedBuilding.GetType().GetMethods())
                {
                    if (item.ReturnType != typeof(string))
                        continue;

                    DrinkDelegate building = item.Invoke;

                    Button b = new();
                    b.Content = item.Name;
                    b.Click += (sender, e) =>
                    {
                        Out.Text = building(SelectedBuilding).ToString();
                    };

                    methods.Children.Add(b);
                }
            }
        }

        void Back_Click(object sender, RoutedEventArgs e)
        {
            NavigationService.GoBack();
        }
    }
}
