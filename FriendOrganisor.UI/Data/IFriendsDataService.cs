using System.Collections.Generic;
using FriendOrganisor.Model;

namespace FriendOrganisor.UI.Data
{
   public interface IFriendsDataService
    {
        IEnumerable<Friend> GetAllFriends();
    }
}