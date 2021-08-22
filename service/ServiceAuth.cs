using bank_oop_sederhana.entity;
using System.Collections.Generic;

namespace bank_oop_sederhana.service
{
    public class ServiceAuth
    {
        public static bool CheckLogin(string inputUsername, string inputPassword)
        {
            if (inputUsername != "" && inputPassword != "")
            {
                var account = AccountImplement.GetAll();

                for (int i = 0; i < account.Count; i++)
                {
                    if (account[i].Username == inputUsername && account[i].Password == inputPassword)
                    {
                        //user login set ke auth data
                        if (AuthImplement.Save(account[i].Id, account[i].Username))
                        {
                            return false;
                        }

                        return true;
                    }
                }

            }
            return true;
        }

        public static bool ClearAuth()
        {
            AuthImplement.GetAll().Clear();
            return true;
        }
    }
}