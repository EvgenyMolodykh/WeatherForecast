namespace Autorization.Models
{
    public class User
    {
        public Guid Id { get; set; }
        public string Login { get; set; }
        public string Password { get; set; }
        public string ConformPassword { get; set; }

        public bool IsSingIn { get; set; }

        public User(string login, string password, string conformPassword)
        {
            Id = Guid.NewGuid();
            Login = login;
            Password = password;
            ConformPassword = conformPassword;
        }

    }
}
