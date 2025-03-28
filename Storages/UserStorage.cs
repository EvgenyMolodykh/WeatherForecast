using BeautifulWeather.Models;

namespace BeautifulWeather.Storages
{
    public class UserStorage
    {
        private const string fileName = "Users.json";
        private List<User> users { get; set; }

        public User TryGetSignedInUser()
        {
            users = GetAllUsers();
            return users.FirstOrDefault(x => x.IsSignedIn);
        }

        public void Add(User user)
        {
            users = GetAllUsers();
            users.Add(user);
            FileProvider.Save(users, fileName);
        }

        private static List<User> GetAllUsers()
        {
            return FileProvider.Load<List<User>>(fileName) ?? new List<User>();
        }

        public void SignOut()
        {
            var signInUser = TryGetSignedInUser();
            if (signInUser != null)
            {
                users = GetAllUsers();
                var existingUser = users.FirstOrDefault(x => x.Login.Equals(signInUser.Login) && x.Password.Equals(signInUser.Password));
                existingUser.IsSignedIn = false;
                FileProvider.Save(users, fileName);
            }
        }

        public bool CheckLogin(string login)
        {
            users = GetAllUsers();
            return users.Any(x => x.Login.Equals(login));
        }

        public User TryGetUserByLogin(string login)
        {
            users = GetAllUsers();
            return users.FirstOrDefault(x => x.Login.Equals(login));
        }

        public bool CheckPassword(User user, string password)
        {
            return user.Password.Equals(password);
        }

        internal void SingIn(User user)
        {
            users = GetAllUsers();
            if (user != null)
            {
                var existingUser = users.FirstOrDefault(x => x.Login.Equals(user.Login) && x.Password.Equals(user.Password));
                existingUser.IsSignedIn = true;
                FileProvider.Save(users, fileName);
            }
        }
    }
}
