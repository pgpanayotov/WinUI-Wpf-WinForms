using EmployeeManager.DataAccess;
using EmployeeManager.ViewModel;
using System.Windows;

namespace EmployeeManager.Wpf
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private MainViewModel viewModel;
        public MainWindow()
        {
            InitializeComponent();
            viewModel = new MainViewModel(new EmployeeDataProvider());
            DataContext = viewModel;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            viewModel.Load();
        }
    }
}
