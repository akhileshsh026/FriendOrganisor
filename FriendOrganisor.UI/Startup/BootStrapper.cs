using Autofac;
using FriendOrganisor.UI.Data;
using FriendOrganisor.UI.ViewModel;

namespace FriendOrganisor.UI.Startup
{
   public class BootStrapper
    {
          public IContainer Bootstrap()       // public method returns an icontainer.
        {
            var builder = new ContainerBuilder();

            builder.RegisterType<MainWindow>().AsSelf();
            builder.RegisterType<MainViewModel>().AsSelf();
            builder.RegisterType<FriendsDataService>().As<IFriendsDataService>();

            return builder.Build();
        }
    }
}
