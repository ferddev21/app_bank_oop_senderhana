using System.Collections.Generic;

namespace bank_oop_sederhana.entity
{
    public class AuthImplement
    {
        public static List<Auth> auth = new List<Auth>();
        public static bool Save(int authIdAccount, string authUsernameAccount)
        {
            auth.Add(
             new Auth(authIdAccount, authUsernameAccount)
            );
            return true;
        }

        public static List<Auth> GetAll()
        {
            return auth;
        }
    }
}