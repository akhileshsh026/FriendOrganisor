using System.Collections.Generic;
using FriendOrganisor.Model;

namespace FriendOrganisor.UI.Data
{
    interface IFriendsDataService
    {
        IEnumerable<Friend> GetAllFriends();
    }
}