namespace bank_oop_sederhana.entity
{
    public class Account
    {
        public Account(int id, string username, string password, int saldo)
        {
            Id = id;
            Username = username;
            Password = password;
            Saldo = saldo;
        }

        public int Id { get; protected set; }
        public string Username { get; protected set; }
        public string Password { get; set; }
        public int Saldo { get; set; }

    }

}