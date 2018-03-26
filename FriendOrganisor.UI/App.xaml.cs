using FriendOrganisor.UI.Data;
using FriendOrganisor.UI.ViewModel;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;

namespace FriendOrganisor.UI
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        private void Application_Startup(object sender, StartupEventArgs e)
        {
            var mainwindow = new MainWindow(
                new MainViewModel(
                    new FriendsDataService()));
            mainwindow.Show();
        }
    }
}
