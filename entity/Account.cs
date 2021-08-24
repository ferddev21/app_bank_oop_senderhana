namespace bank_oop_sederhana.entity
{
    public class Account
    {
        public Account()
        {
        }

        public Account(int id, string username, string password, int saldo)
        {
            Id = id;
            Username = username;
            Password = password;
            Saldo = saldo;
        }

        public int Id { get; protected internal set; }
        public string Username { get; protected internal set; }
        public string Password { get; protected internal set; }
        public int Saldo { get; protected internal set; }

    }

}