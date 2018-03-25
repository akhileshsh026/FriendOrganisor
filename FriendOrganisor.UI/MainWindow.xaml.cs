using FriendOrganisor.UI.ViewModel;
using System.Windows;

namespace FriendOrganisor.UI
{
    
    public partial class MainWindow : Window
    {
        public MainWindow(MainViewModel viewmodel)
        {
            InitializeComponent();
            DataContext = viewmodel;
            viewmodel.Load(); //bad idea
        }
    }
}
