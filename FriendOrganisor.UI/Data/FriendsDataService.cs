using FriendOrganisor.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FriendOrganisor.UI.Data
{
    class FriendsDataService : IFriendsDataService
    {
        public IEnumerable<Friend> GetAllFriends()
        {
            // To Do Getting this data  from the Database after this thing.
            yield return new Friend { Id = 1, FirstName = "Akhilesh Kumar", LastName = "Rajendra", Email = "akhileshsh026@hotmail.com" };
            yield return new Friend { Id = 2, FirstName = "Arpit", LastName = "Kanda", Email = "Arpit.kanda@dimentionx.in" };
            yield return new Friend { Id = 3, FirstName = "Surendra", LastName = "Chouksey", Email = "Surendra.Chouksey@dimentionx.in" };
            
        }
    }
}
