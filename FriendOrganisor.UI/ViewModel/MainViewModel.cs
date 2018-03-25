using FriendOrganisor.Model;
using FriendOrganisor.UI.Data;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganisor.UI.ViewModel
{
    public class MainViewModel : ViewModelBase
    {
        private IFriendsDataService _frienddataService;
        private Friend _SelectedFriend;

       

        public MainViewModel(IFriendsDataService friendDataService) 
        {
            Friends = new ObservableCollection<Friend>();
            _frienddataService = friendDataService;
        }

        public void Load()
        {
            var friends = _frienddataService.GetAllFriends();
            Friends.Clear();
            foreach (var friend in friends)
            {
                Friends.Add(friend);
            }
        }
        public ObservableCollection<Friend> Friends { get; set; } 

        public Friend SelectedFriend
        {
            get { return _SelectedFriend; }
            set
            {
                _SelectedFriend = value;
                OnPropertyChanged(); 
            }
        }

      

    }

    public class ViewModelBase : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;
        protected virtual void OnPropertyChanged([CallerMemberName]string PropertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(PropertyName));
        }
    }

}
