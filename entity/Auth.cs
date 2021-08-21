namespace bank_oop_sederhana.entity
{
    public class Auth
    {
        public Auth(int authIdAccount, string authUsernameAccount)
        {
            AuthIdAccount = authIdAccount;
            AuthUsernameAccount = authUsernameAccount;
        }

        public int AuthIdAccount { get; set; }
        public string AuthUsernameAccount { get; set; }
    }
}