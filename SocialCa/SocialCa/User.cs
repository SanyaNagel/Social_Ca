using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SocialCa
{
    class User
    {
        private String name;
        private String surname;
        private List<int> listFriends;
        public int id;
        public User(int id)
        {
            this.id = id;
            listFriends = new List<int>();
        }

        /// <summary>
        /// Функция добавления пользователя в друзья
        /// </summary>
        /// <param name="id"></param>
        public void addFriend(int id)
        {
            listFriends.Add(id);
        }
    }
}
