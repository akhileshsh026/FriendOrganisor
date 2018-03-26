using FriendOrganisor.UI.ViewModel;
using System.Windows;

namespace FriendOrganisor.UI
{
    
    public partial class MainWindow : Window
    {
        private MainViewModel _viewmodel;
        public MainWindow(MainViewModel viewmodel)
        {
            InitializeComponent();
            _viewmodel = viewmodel;
            DataContext = _viewmodel;
            Loaded += MainWindow_Loaded;
        }

        private void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            _viewmodel.Load();
        }
    }
}
