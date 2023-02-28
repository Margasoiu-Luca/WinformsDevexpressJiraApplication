namespace BusinessLogic.Models
{
    internal class User
    {
        public int? id { get; set; }
        public string username { get; set; }
        public string password { get; set; }
        public User()
        {
        }
        public User(int Id, string Username, string Password)
        {
            this.username = Username;
            this.password = Password;
            this.id = Id;
        }
        public User(string username, string password)
        {
            this.username = username;
            this.password = password;
        }
    }
}

