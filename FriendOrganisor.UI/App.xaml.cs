using Autofac;
using FriendOrganisor.UI.Data;
using FriendOrganisor.UI.Startup;
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
            var bootstrapper = new BootStrapper();
            var container = bootstrapper.Bootstrap();
            var mainwindow = container.Resolve<MainWindow>();
            mainwindow.Show();
        }
    }
}
